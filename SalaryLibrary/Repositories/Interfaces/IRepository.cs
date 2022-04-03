using System.Collections.Generic;

namespace SalaryManager.DAL.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Create(T entity);
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Update(T entity);
        void Delete(T entity);
    }
}
