using MySql.Data.MySqlClient;
using SalaryManager.ORM.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryManager.ORM
{
    public class MySqlExecutor : ISqlExecutor, IDisposable
    {
        private string _conectionStr;
        private MySqlConnection _connection;
        public MySqlExecutor(string conectionString)
        {
            _conectionStr = conectionString;
            _connection = new MySqlConnection(_conectionStr);
            _connection.Open();
        }

        public void Dispose()
        {
            _connection.Dispose();
        }

        public int ExecuteNonQuery(string sqlCommand)
        {
            int n = -1;

            using (MySqlCommand cmd = new MySqlCommand(sqlCommand, _connection))
            {
                n = cmd.ExecuteNonQuery();
            }

            return n;
        }

        public object ExecuteScalar(string sqlCommand)
        {
            object data;

            using (MySqlCommand cmd = new MySqlCommand(sqlCommand, _connection))
            {
                data = cmd.ExecuteScalar();
            }

            return data;
        }

        public DataSet GetDataSet(string sqlCommand)
        {
            DataSet ds = new DataSet();

            MySqlDataAdapter adapter = new MySqlDataAdapter(sqlCommand.ToString(), _connection);
            adapter.Fill(ds);

            return ds;
        }
    }
}
