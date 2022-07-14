using ProductDBEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDBEntityFramework.Repository
{
    public class PaymentRepositoryEF : IRepository<Payment>
    {
        PRN_ProductDBContext db = new PRN_ProductDBContext();
        public int Create(Payment entity)
        {
            try
            {
                //db.Payments.Add(entity);
                db.Payments.Add(new Payment { PayTime = entity.PayTime, Amount = entity.Amount, PayType = entity.PayType, OrderId = entity.OrderId });
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
                var payment = db.Payments.Where(payment => payment.Id == id).FirstOrDefault();
                if (payment != null)
                {
                    db.Payments.Remove(payment);
                    result = db.SaveChanges() > 0;
                }
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Payment> Get()
        {
            try
            {
                return db.Payments.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Payment GetTById(int id)
        {
            try
            {
                return db.Payments.Where((payment) => payment.Id == id).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(Payment entity)
        {
            try
            {
                bool result = false;
                var payment = db.Payments.Where(payment => payment.Id == entity.Id).FirstOrDefault();
                if (payment != null)
                {
                    payment.PayTime = entity.PayTime;
                    payment.Amount = entity.Amount;
                    payment.PayType = entity.PayType;
                    payment.OrderId = entity.OrderId;
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
        /// Return special list without id as EF cannot add Payment with IDENTITY id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Payment> getByOrderID(int id)
        {
            try
            {
                List<Payment> tmpList = db.Payments.Where(payment => payment.OrderId == id).ToList();
                List < Payment > returnList = new();
                foreach (var item in tmpList)
                {
                    Payment payment = new Payment();
                    payment.PayTime = item.PayTime;
                    payment.Amount = item.Amount;
                    payment.PayType = item.PayType;
                    payment.OrderId = item.OrderId;
                    returnList.Add(payment);
                }
                return returnList;
                


                //return db.Payments.Where(payment => payment.OrderId == id).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Return full list with PaymentID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Payment> getByOrderIDReturnWithPaymentID(int id)
        {
            try
            {
                return db.Payments.Where(payment => payment.OrderId == id).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
