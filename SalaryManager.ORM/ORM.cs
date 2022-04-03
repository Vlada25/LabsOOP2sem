using SalaryManager.ORM.Interfaces;
using System;
using System.Data;

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

        public bool DeleteValue(Type type, int id)
        {
            throw new NotImplementedException();
        }

        public DataRow GetValue(Type type, int id)
        {
            throw new NotImplementedException();
        }

        public void InsertValue(string tableName, string sqlCom)
        {
            if (!_tableManager.IsTableExists(tableName))
            {
                throw new Exception($"Table {tableName} is not exist");
            }

            _sqlExecutor.ExecuteNonQuery(sqlCom);
        }

        public void UpdateValue(Type type, int id, string sqlComPart)
        {
            throw new NotImplementedException();
        }
    }
}
