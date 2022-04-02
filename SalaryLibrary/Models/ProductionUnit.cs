using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryManager.DAL.Models
{
    public class ProductionUnit
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public ProductionUnit(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

    }
}
