using SalaryLibrary;
using SalaryManager.DAL.Models;
using SalaryManager.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;

namespace SalaryManager.DAL.Repositories
{
    public class WorkerCategoryRepository : IWorkerCtegoryRepository
    {
        public void Create(WorkerCategory entity)
        {
            string query = "INSERT WorkerCategories (CategoryName, TariffCoefficient)" +
                $"VALUES ('{entity.Name}', {entity.TariffCoefficient});";

            Service.ORM.InsertValue("WorkerCategories", query);
        }

        public void Delete(WorkerCategory entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<WorkerCategory> GetAll()
        {
            throw new NotImplementedException();
        }

        public WorkerCategory GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(WorkerCategory entity)
        {
            throw new NotImplementedException();
        }
    }
}
