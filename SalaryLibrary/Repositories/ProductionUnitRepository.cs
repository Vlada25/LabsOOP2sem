﻿using SalaryLibrary;
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
            string query = "INSERT ProductionUnits (Id, UnitName, Price)" +
                $"VALUES ({entity.Id}, '{entity.UnitName}', {entity.Price.ToString().Replace(',', '.')});";

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
            string query = $"UnitName = '{entity.UnitName}', Price = {entity.Price.ToString().Replace(',', '.')}";

            Service.ORM.UpdateValue("ProductionUnits", entity.Id, query);
        }
    }
}
