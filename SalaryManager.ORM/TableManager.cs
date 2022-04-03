using SalaryManager.ORM.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryManager.ORM
{
    public class TableManager : ITableManager, IDisposable
    {
        private readonly Type[] _baseFieldTypes = new Type[]
        {
            typeof(string),
            typeof(int),
            typeof(double),
            typeof(decimal),
            typeof(DateTime),
            typeof(bool),
        };

        private MySqlExecutor _sqlExecutor;
        public TableManager(string connectionString)
        {
            _sqlExecutor = new MySqlExecutor(connectionString);
        }

        public void Dispose()
        {
            _sqlExecutor.Dispose();
        }

        public DataSet GetDataSet(string tableName)
        {
            if (!IsTableExists(tableName))
            {
                throw new Exception($"Table {tableName} is not exist");
            }

            return _sqlExecutor.GetDataSet($"SELECT * FROM {tableName}");
        }

        public bool ClearTable(string tableName)
        {
            if (!IsTableExists(tableName))
            {
                return false;
            }

            _sqlExecutor.ExecuteNonQuery($"DELETE FROM {tableName}");

            return true;
        }

        public bool IsTableExists(string tableName)
        {
            string sql = $"SELECT * FROM {tableName}";
            try
            {
                _sqlExecutor.ExecuteScalar(sql);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
