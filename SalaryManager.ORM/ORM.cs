using SalaryManager.ORM.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void InsertValue(Type type, int id, string sqlComPart)
        {
            throw new NotImplementedException();
        }

        public void UpdateValue(Type type, int id, string sqlComPart)
        {
            throw new NotImplementedException();
        }
    }
}
