using SalaryLibrary;
using SalaryManager.DAL.Models;
using SalaryManager.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;

namespace SalaryManager.DAL.Repositories
{
    public class WorkerRepository : IWorkerRepository
    {
        public void Create(Worker entity)
        {
            string query = "INSERT Workers (FullName, WorkerCategoryId, BillingPeriodDate, AmountOfWorkDone, ProductionUnitId)" +
                $"VALUES ('{entity.FullName}', {entity.WorkerCategoryId}, {entity.BillingPeriodDate}, {entity.AmountOfWorkDone}, " +
                $"{entity.ProductionUnitId});";

            Service.ORM.InsertValue("Workers", query);
        }

        public void Delete(Worker entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Worker> GetAll()
        {
            throw new NotImplementedException();
        }

        public Worker GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Worker entity)
        {
            throw new NotImplementedException();
        }
    }
}
