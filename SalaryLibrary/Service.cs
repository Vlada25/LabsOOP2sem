using SalaryManager.ORM;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        
        public static string ViewTable(string tableName)
        {
            return GetStrTable(TableManager.GetDataSet(tableName));
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
