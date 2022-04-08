using SalaryManager.ORM.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;

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

        public DataSet GetSpecialDataSet(string fields, string afterFrom)
        {
            return _sqlExecutor.GetDataSet($"SELECT {fields} FROM {afterFrom}");
        }

        public void ClearTable(string tableName)
        {
            if (!IsTableExists(tableName))
            {
                throw new Exception($"Table {tableName} is not exist");
            }

            _sqlExecutor.ExecuteNonQuery($"DELETE FROM {tableName}");
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

        public void CreateTable(Type type, string tableName, params string[] foreignKeys)
        {
            if (!IsTableExists(tableName))
            {
                StringBuilder sqlQuery = new StringBuilder();

                sqlQuery.Append($"CREATE TABLE {tableName} (Id INT PRIMARY KEY, ");

                foreach (var pair in GetColumns(type, foreignKeys))
                {
                    sqlQuery.AppendLine($"{pair.Key} {pair.Value},");
                }

                sqlQuery.Remove(sqlQuery.Length - 3, 1);
                sqlQuery.Append(")");

                _sqlExecutor.ExecuteNonQuery(sqlQuery.ToString());
            }
        }

        public void DeleteTable(string tableName)
        {
            if (!IsTableExists(tableName))
            {
                throw new Exception($"Table {tableName} is not exist");
            }

            _sqlExecutor.ExecuteNonQuery($"DROP TABLE {tableName}");
        }

        private Dictionary<string, string> GetColumns(Type modelType, params string[] foreignKeys)
        {
            Dictionary<string, string> columns = new Dictionary<string, string>();
            var properties = modelType.GetProperties();

            var allProps = from prop in properties
                           where _baseFieldTypes.Contains(prop.PropertyType) && prop.Name != "Id"
                           select prop;

            string value = "";
            int index = 0;

            foreach (var p in allProps)
            {
                value = GetModelType(p.PropertyType.Name) + " NOT NULL";
                columns.Add(p.Name, value);

                if (p.Name.Substring(p.Name.Length - 2) == "Id")
                {
                    value = $"FOREIGN KEY ({p.Name}) REFERENCES {foreignKeys[index]} (Id) ON DELETE CASCADE";
                    columns.Add(value, "");
                    index++;
                }
            }

            return columns;
        }

        public IEnumerable<PropertyInfo> GetBaseProps(Type type, bool forCreation = true)
        {
            if (forCreation)
                return from prop in type.GetProperties()
                       where _baseFieldTypes.Contains(prop.PropertyType)
                       select prop;

            return from prop in type.GetProperties()
                   where _baseFieldTypes.Contains(prop.PropertyType) && prop.Name != "Id"
                   select prop;
        }

        private string GetModelType(string typeName)
        {
            switch (typeName)
            {
                case "DateTime":
                    return "DATE";
                case "String":
                    return "VARCHAR(50)";
                case "Int32":
                    return "INT";
                case "Decimal":
                    return "DECIMAL";
                case "Double":
                    return "DOUBLE";
                default:
                    throw new Exception("This data type is not processed");
            }
        }
    }
}
