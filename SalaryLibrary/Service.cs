using SalaryLibrary.Repositories.LocalRepositories;
using SalaryManager.DAL.Models;
using SalaryManager.DAL.Repositories;
using SalaryManager.ORM;
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

        public static string ViewTable(string tableName)
        {
            return GetStrTable(TableManager.GetDataSet(tableName));
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

        private static string GetStrTable(DataSet dataSet)
        {
            string result = "";

            foreach (DataTable table in dataSet.Tables)
            {
                foreach (DataColumn column in table.Columns)
                {
                    result += $"{column.ColumnName} --- ";
                }

                result += "\n";

                foreach (DataRow row in table.Rows)
                {
                    var cells = row.ItemArray;

                    foreach (object cell in cells)
                    {
                        result += $"{cell} --- ";
                    }

                    result += "\n";
                }
            }

            return result;
        }
    }
}
