using System.Collections.Generic;

namespace ProductDBEntityFramework.Repository
{
    internal interface IRepository<T> where T : class
    {
        int Create(T entity);
        bool Delete(int id);
        bool Update(T entity);
        T GetTById(int id);
        List<T> Get();
    }
}
