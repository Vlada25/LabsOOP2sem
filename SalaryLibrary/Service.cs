using SalaryLibrary.Repositories.LocalRepositories;
using SalaryManager.DAL.Models;
using SalaryManager.DAL.Repositories;
using SalaryManager.ORM;
using System;
using System.Collections.Generic;
using System.Data;

namespace SalaryLibrary
{
    public static class Service
    {
        public static string[] TablesInDb { get; } =
        {
            "ProductionUnits",
            "Workers",
            "WorkerCategories"
        };

        private static string _connectionString = "Server=localhost;Database=salarymanager;Uid=root;pwd=1111;";

        public static TableManager TableManager { get; } = new TableManager(_connectionString);
        public static ORM ORM { get; } = new ORM(_connectionString);

        private static UnitOfWork _repositories = new UnitOfWork();

        public static void CreateTables()
        {
            TableManager.CreateTable(typeof(ProductionUnit), TablesInDb[0]);
            TableManager.CreateTable(typeof(WorkerCategory), TablesInDb[2]);
            TableManager.CreateTable(typeof(Worker), TablesInDb[1], "WorkerCategories", "ProductionUnits");
        }

        public static void InitStartValues()
        {
            foreach (ProductionUnit unit in LProductionUnitRepository.ProductionUnits)
                _repositories.ProductionUnit.Create(unit);
            foreach (WorkerCategory category in LWorkerCategoryRepository.WorkerCategories)
                _repositories.WorkerCategory.Create(category);
            foreach (Worker worker in LWorkerRepository.Workers)
                _repositories.Worker.Create(worker);
        }

        public static void CreateEntity(Type type, List<string> propsValues)
        {
            switch (type.Name)
            {
                case "ProductionUnit":
                    ProductionUnit unit = new ProductionUnit(
                        Convert.ToInt32(propsValues[0]), propsValues[1], 
                        Convert.ToDecimal(propsValues[2]));
                    _repositories.ProductionUnit.Create(unit);
                    break;
                case "WorkerCategory":
                    WorkerCategory category = new WorkerCategory(
                        Convert.ToInt32(propsValues[0]), propsValues[1],
                        Convert.ToDouble(propsValues[2]));
                    _repositories.WorkerCategory.Create(category);
                    break;
                case "Worker":
                    Worker worker = new Worker(
                        Convert.ToInt32(propsValues[0]), propsValues[1],
                        Convert.ToInt32(propsValues[2]), Convert.ToDateTime(propsValues[3]),
                        Convert.ToInt32(propsValues[4]), Convert.ToInt32(propsValues[5]));
                    _repositories.Worker.Create(worker);
                    break;
            }
        }

        public static void UpdateEntity(Type type, List<string> propsValues)
        {
            switch (type.Name)
            {
                case "ProductionUnit":
                    ProductionUnit unit = new ProductionUnit(
                        Convert.ToInt32(propsValues[0]), propsValues[1],
                        Convert.ToDecimal(propsValues[2]));
                    _repositories.ProductionUnit.Update(unit);
                    break;
                case "WorkerCategory":
                    WorkerCategory category = new WorkerCategory(
                        Convert.ToInt32(propsValues[0]), propsValues[1],
                        Convert.ToDouble(propsValues[2]));
                    _repositories.WorkerCategory.Update(category);
                    break;
                case "Worker":
                    Worker worker = new Worker(
                        Convert.ToInt32(propsValues[0]), propsValues[1],
                        Convert.ToInt32(propsValues[2]), Convert.ToDateTime(propsValues[3]),
                        Convert.ToInt32(propsValues[4]), Convert.ToInt32(propsValues[5]));
                    _repositories.Worker.Update(worker);
                    break;
            }
        }

        public static Type GetEntityType(string tableName)
        {
            switch (tableName)
            {
                case "ProductionUnits":
                    return typeof(ProductionUnit);
                case "WorkerCategories":
                    return typeof(WorkerCategory);
                case "Workers":
                    return typeof(Worker);
                default:
                    throw new Exception("Such model type is not exiscts");
            }
        }
    }
}
