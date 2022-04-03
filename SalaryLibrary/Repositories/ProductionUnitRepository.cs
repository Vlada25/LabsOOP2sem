using SalaryLibrary;
using SalaryManager.DAL.Models;
using SalaryManager.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;

namespace SalaryManager.DAL.Repositories
{
    public class ProductionUnitRepository : IProductionUnitRepository
    {
        public void Create(ProductionUnit entity)
        {
            string query = "INSERT ProductionUnits (UnitName, Price)" +
                $"VALUES ('{entity.Name}', {entity.Price});";

            Service.ORM.InsertValue("ProductionUnits", query);
        }

        public void Delete(ProductionUnit entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductionUnit> GetAll()
        {
            throw new NotImplementedException();
        }

        public ProductionUnit GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(ProductionUnit entity)
        {
            throw new NotImplementedException();
        }
    }
}
