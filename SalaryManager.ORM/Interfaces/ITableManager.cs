using System;

namespace SalaryManager.ORM.Interfaces
{
    public interface ITableManager
    {
        void CreateTable(Type type, string tableName, params string[] foreignKeys);
        void ClearTable(string tableName);
        void DeleteTable(string tableName);
    }
}
