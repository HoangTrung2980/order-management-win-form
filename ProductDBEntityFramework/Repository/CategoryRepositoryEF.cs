using ProductDBEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductDBEntityFramework.Repository
{
    public class CategoryRepositoryEF : IRepository<Category>
    {
        PRN_ProductDBContext db = new PRN_ProductDBContext();

        public int Create(Category entity)
        {
            try
            {
                db.Categories.Add(entity);
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
                var category = db.Categories.Where(category => category.Id == id).FirstOrDefault();
                if (category != null)
                {
                    category.Status = 0;
                    result = db.SaveChanges() > 0;
                }
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Category> Get()
        {
            try
            {
                return db.Categories.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Category GetTById(int id)
        {
            try
            {
                return db.Categories.Where((category) => category.Id == id).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(Category entity)
        {
            try
            {
                bool result = false;
                var category = db.Categories.Where(category => category.Id == entity.Id).FirstOrDefault();
                if (category != null)
                {
                    category.Name = entity.Name;
                    category.Status = entity.Status;
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
