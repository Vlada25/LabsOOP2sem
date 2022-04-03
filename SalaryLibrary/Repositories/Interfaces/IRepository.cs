using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
