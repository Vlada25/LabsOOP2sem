﻿using System;
using System.Data;

namespace SalaryManager.ORM.Interfaces
{
    public interface IORM
    {
        void InsertValue(string tableName, string sqlComPart);
        DataRow GetValue(Type type, int id);
        void UpdateValue(Type type, int id, string sqlComPart);
        bool DeleteValue(Type type, int id);
    }
}
