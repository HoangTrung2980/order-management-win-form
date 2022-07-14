using Microsoft.Data.SqlClient;
using ProductDBEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductDBEntityFramework.Repository
{
    public class ProductRepositoryEF : IRepository<Product>
    {
        PRN_ProductDBContext db = new PRN_ProductDBContext();
        private string ConnectionString = @"Server =(local); database=PRN_productDB; user id=sa; password=sa12345";
        SqlConnection conn;
        public double GetProductPrice(int productId)
        {
            try
            {
                conn = new SqlConnection(ConnectionString);
                SqlCommand cmd = new SqlCommand("SELECT Price FROM Product WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", productId);

                conn.Open();
                var reader = cmd.ExecuteReader();
                double returnPrice = 0;
                if (reader.Read())
                {
                    returnPrice = (double)reader["Price"];
                }
                conn.Close();
                return returnPrice;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int Create(Product entity)
        {
            try
            {
                //db.Products.Add(entity); // Can not add all at the same time as id column is IDENTITY
                Product product = new Product();    
                //product.Id = entity.Id;
                product.Name = entity.Name;
                product.Price = entity.Price;
                product.CreatedDate = entity.CreatedDate;
                product.Status = entity.Status;
                product.CategoryId = entity.CategoryId;

                db.Products.Add(new Product
                {
                    Name = entity.Name,
                    Price = entity.Price,
                    CreatedDate = entity.CreatedDate,
                    Status = entity.Status,
                    CategoryId = entity.CategoryId
                });

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
                var product = db.Products.Where(product => product.Id == id).FirstOrDefault();
                if (product != null)
                {
                    product.Status = 0;
                    result = db.SaveChanges() > 0;
                }
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Product> Get()
        {
            try
            {
                return db.Products.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Product GetTById(int id)
        {
            try
            {
                return db.Products.Where((product) => product.Id == id).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(Product entity)
        {
            try
            {
                bool result = false;
                var product = db.Products.Where(product => product.Id == entity.Id).FirstOrDefault();
                if (product != null)
                {
                    product.Name = entity.Name;
                    product.Price = entity.Price;
                    product.Status = entity.Status;
                    product.CategoryId = entity.CategoryId;
                    product.CreatedDate = entity.CreatedDate;
                    result = db.SaveChanges() > 0;
                }
                return result;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
