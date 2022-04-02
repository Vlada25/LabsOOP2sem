using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryManager.DAL.Models
{
    public class WorkerCategory
    {
        public string Name { get; set; }
        public double TariffCoefficient { get; set; } // процент к зарплате в зависимости от категории

        public WorkerCategory(string name, double tariffCoefficient)
        {
            Name = name;
            TariffCoefficient = tariffCoefficient;
        }

    }
}
