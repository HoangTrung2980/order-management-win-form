using Microsoft.Data.SqlClient;
using ProductDBEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProductDBEntityFramework.Repository
{
    public class OrderRepositoryEF : IRepository<Order>
    {
        PRN_ProductDBContext db = new PRN_ProductDBContext();
        private string ConnectionString = @"Server =(local); database=PRN_productDB; user id=sa; password=sa12345";
        SqlConnection conn;
        public int GetNewOrderID()
        {
            try
            {
                conn = new SqlConnection(ConnectionString);
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 Id FROM [Order] ORDER BY Id DESC", conn);

                conn.Open();
                var reader = cmd.ExecuteReader();
                int returnId = 0;
                if (reader.Read())
                {
                    returnId = (int)reader["Id"];
                }
                conn.Close();
                return returnId+1;
            }
            catch (Exception)
            {

                throw;
            }
        }



        public int Create(Order entity)
        {
            try
            {
                //db.Orders.Add(entity); // Can not add all at the same time as id column is IDENTITY
                Order order = new Order();
                //order.Id = entity.Id;
                order.CustomerName = entity.CustomerName;
                order.Address = entity.Address;
                order.Price = entity.Price;
                order.OrderDate = entity.OrderDate;
                order.Status = entity.Status;

                db.Orders.Add(new Order
                {
                    CustomerName = order.CustomerName,
                    Address = order.Address,
                    Price = order.Price,
                    OrderDate = order.OrderDate,
                    Status = order.Status
                });
                db.SaveChanges();

                //--------------Payment----------------
                PaymentRepositoryEF paymentRepositoryEF = new PaymentRepositoryEF();
                foreach (Payment payMent in entity.Payments)
                {
                    paymentRepositoryEF.Create(payMent);
                }
                // get list of Payment with OrderId and return the list WITHOUT PaymentID!!! (EF can detect it's IDENTITY and can't not add it to the order data)
                order.Payments = paymentRepositoryEF.getByOrderID(entity.Id);
                

                //--------------OrderDetail----------------
                OrderDetailRepositoryEF orderDetailRepositoryEF = new OrderDetailRepositoryEF();
                foreach (OrderDetail orderDetail in entity.OrderDetails)
                {
                    orderDetailRepositoryEF.Create(orderDetail);
                }
                // get list of OrderDetail with OrderId and return the list WITHOUT OrderDetailID!!! (EF can detect it's IDENTITY and can't not add it to the order data)
                order.OrderDetails = orderDetailRepositoryEF.getByOrderID(entity.Id);

                //db.Orders.Add(order); (ERROR)

                // NOTE: only add once to get orderId for Payment and OrderDetail!!! (error code left here to remember this error, pls don't delete it)

                //db.Orders.Add(new Order
                //{
                //    Payments = order.Payments,
                //    OrderDetails = order.OrderDetails
                //}); (ERROR)

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
                var order = db.Orders.Where(order => order.Id == id).FirstOrDefault();
                if (order != null)
                {
                    //db.Orders.Remove(order);
                    order.Status = 0;
                    result = db.SaveChanges() > 0;
                }
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Order> Get()
        {
            try
            {
                PaymentRepositoryEF paymentRepositoryEF = new PaymentRepositoryEF();
                OrderDetailRepositoryEF orderDetailRepositoryEF = new OrderDetailRepositoryEF();
                List<Order> listOrder = db.Orders.ToList();
                foreach (Order order in listOrder)
                {
                    order.Payments = paymentRepositoryEF.getByOrderIDReturnWithPaymentID(order.Id);// add in manually as 'get' table [Order] is not enough
                    order.OrderDetails = orderDetailRepositoryEF.getByOrderIDReturnWithOrderDetailID(order.Id);// add in manually as 'get' table [Order] is not enough
                }


                return listOrder;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Order GetTById(int id)
        {
            try
            {
                PaymentRepositoryEF paymentRepositoryEF = new PaymentRepositoryEF();
                OrderDetailRepositoryEF orderDetailRepositoryEF = new OrderDetailRepositoryEF();
                Order order = db.Orders.Where(order => order.Id == id).FirstOrDefault();
                order.Payments = paymentRepositoryEF.getByOrderIDReturnWithPaymentID(id);// add in manually as 'get' table [Order] is not enough
                order.OrderDetails = orderDetailRepositoryEF.getByOrderIDReturnWithOrderDetailID(id);// add in manually as 'get' table [Order] is not enough

                return order;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(Order entity)
        {
            try
            {
                bool resultOrder = false;
                bool resultPayment = false;
                bool resultOrderDetail = false;
                var order = db.Orders.Where(order => order.Id == entity.Id).FirstOrDefault();
                if (order != null)
                {
                    //--------update Order----------
                    order.CustomerName = entity.CustomerName;
                    order.Address = entity.Address;
                    order.Price = entity.Price;
                    order.OrderDate = entity.OrderDate;
                    order.Status = entity.Status;
                    order.Payments = entity.Payments;
                    order.OrderDetails = entity.OrderDetails;
                    resultOrder = db.SaveChanges() > 0;

                    //--------update Payment--------
                    PaymentRepositoryEF paymentRepositoryEF = new PaymentRepositoryEF();
                    foreach (Payment payMent in entity.Payments)
                    {
                        resultPayment = paymentRepositoryEF.Update(payMent);
                        if (resultPayment == false)
                        {
                            break;
                        }
                    }

                    //-------update OrderDetail------
                    OrderDetailRepositoryEF orderDetailRepositoryEF = new OrderDetailRepositoryEF();
                    foreach (OrderDetail orderDetail in entity.OrderDetails)
                    {
                        resultOrderDetail = orderDetailRepositoryEF.Update(orderDetail);
                        if (resultOrderDetail == false)
                        {
                            break;
                        }
                    }


                }
                return (resultOrder && resultPayment && resultOrderDetail);
                //return resultOrder;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
