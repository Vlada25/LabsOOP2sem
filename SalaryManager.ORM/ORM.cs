using SalaryManager.ORM.Interfaces;
using System;
using System.Data;
using System.Linq;

namespace SalaryManager.ORM
{
    public class ORM : IORM
    {
        private MySqlExecutor _sqlExecutor;
        private static TableManager _tableManager;
        public ORM(string connectionString)
        {
            _tableManager = new TableManager(connectionString);
            _sqlExecutor = new MySqlExecutor(connectionString);
        }

        public void DeleteValue(string tableName, int id)
        {
            if (!_tableManager.IsTableExists(tableName))
            {
                throw new Exception($"Table {tableName} is not exist");
            }

            string query = $"DELETE FROM {tableName} WHERE Id = {id}";
            _sqlExecutor.ExecuteNonQuery(query);
        }

        public DataRow GetValue(string tableName, Type type, int id)
        {
            if (!_tableManager.IsTableExists(tableName))
            {
                throw new Exception("Table is not exists");
            }

            DataSet dataSet = _sqlExecutor.GetDataSet($"SELECT * FROM {tableName}");

            try
            {
                return (from obj in dataSet.Tables[0].AsEnumerable()
                           where (int)obj["Id"] == id
                           select obj).First();
            }
            catch 
            {
                throw new Exception("Entity is not found");
            }
        }

        public void InsertValue(string tableName, string sqlCom)
        {
            if (!_tableManager.IsTableExists(tableName))
            {
                throw new Exception($"Table {tableName} is not exist");
            }

            _sqlExecutor.ExecuteNonQuery(sqlCom);
        }

        public void UpdateValue(string tableName, int id, string sqlComPart)
        {
            _sqlExecutor.ExecuteNonQuery($"UPDATE {tableName} SET {sqlComPart} WHERE Id = {id};");
        }
    }
}
