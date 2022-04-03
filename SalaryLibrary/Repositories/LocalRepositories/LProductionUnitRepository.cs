using SalaryManager.DAL.Models;
using System.Collections.Generic;

namespace SalaryLibrary.Repositories.LocalRepositories
{
    public static class LProductionUnitRepository
    {
        public static List<ProductionUnit> ProductionUnits { get; } = new List<ProductionUnit>
        {
            new ProductionUnit(1, "Screen of Android phone", 12000),
            new ProductionUnit(2, "Screen of Apple phones", 35000),
            new ProductionUnit(3, "Mersedes car wheel", 720000),
            new ProductionUnit(4, "Tesla car panel", 900000),
            new ProductionUnit(5, "Phone battery", 5000)
        };
    }
}
