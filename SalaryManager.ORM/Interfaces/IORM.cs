using System;
using System.Data;

namespace SalaryManager.ORM.Interfaces
{
    public interface IORM
    {
        void InsertValue(string tableName, string sqlComPart);
        DataRow GetValue(string tableName, Type type, int id);
        void UpdateValue(string tableName, int id, string sqlComPart);
        void DeleteValue(string tableName, int id);
    }
}
