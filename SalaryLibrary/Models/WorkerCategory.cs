using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryManager.DAL.Models
{
    public class WorkerCategory
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public double TariffCoefficient { get; set; } // процент к зарплате в зависимости от категории

        public WorkerCategory(int id, string name, double tariffCoefficient)
        {
            Id = id;
            CategoryName = name;
            TariffCoefficient = tariffCoefficient;
        }

    }
}
