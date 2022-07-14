using ProductDBEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDBEntityFramework.Repository
{
    public class OrderDetailRepositoryEF : IRepository<OrderDetail>
    {
        PRN_ProductDBContext db = new PRN_ProductDBContext();
        public int Create(OrderDetail entity)
        {
            try
            {
                //db.OrderDetails.Add(entity);
                db.OrderDetails.Add(new OrderDetail { ProductId = entity.ProductId, OrderId = entity.OrderId, Quantity = entity.Quantity, Price = entity.Price });
                db.SaveChanges();
                return entity.Id;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                bool result = false;
                var orderDetail = db.OrderDetails.Where(orderDetail => orderDetail.Id == id).FirstOrDefault();
                if (orderDetail != null)
                {
                    db.OrderDetails.Remove(orderDetail);
                    result = db.SaveChanges() > 0;
                }
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<OrderDetail> Get()
        {
            try
            {
                return db.OrderDetails.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public OrderDetail GetTById(int id)
        {
            try
            {
                return db.OrderDetails.Where((orderDetail) => orderDetail.Id == id).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(OrderDetail entity)
        {
            try
            {
                bool result = false;
                var orderDetail = db.OrderDetails.Where(orderDetail => orderDetail.Id == entity.Id).FirstOrDefault();
                if (orderDetail != null)
                {
                    orderDetail.ProductId = entity.ProductId;
                    orderDetail.OrderId = entity.OrderId;
                    orderDetail.Quantity = entity.Quantity;
                    orderDetail.Price = entity.Price;
                    result = db.SaveChanges() > 0;
                }
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Return special list without id as EF cannot add OrderDetail with IDENTITY id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<OrderDetail> getByOrderID(int id)
        {
            try
            {
                List<OrderDetail> tmpList = db.OrderDetails.Where(orderDetail => orderDetail.OrderId == id).ToList();
                List<OrderDetail> returnList = new();
                foreach (var item in tmpList)
                {
                    OrderDetail orderDetail = new OrderDetail();
                    orderDetail.ProductId=item.ProductId;
                    orderDetail.OrderId=item.OrderId;
                    orderDetail.Quantity=item.Quantity;
                    orderDetail.Price=item.Price;
                    returnList.Add(orderDetail);
                }
                return returnList;

                //return db.OrderDetails.Where(orderDetail => orderDetail.OrderId == id).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Return full list with OrderDetailID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<OrderDetail> getByOrderIDReturnWithOrderDetailID(int id)
        {
            try
            {
                return db.OrderDetails.Where(orderDetail => orderDetail.OrderId == id).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
