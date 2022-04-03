using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryManager.ORM.Interfaces
{
    public interface IORM
    {
        void InsertValue(Type type, int id, string sqlComPart);
        DataRow GetValue(Type type, int id);
        void UpdateValue(Type type, int id, string sqlComPart);
        bool DeleteValue(Type type, int id);
    }
}
