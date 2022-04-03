using SalaryManager.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SalaryLibrary.Repositories.LocalRepositories
{
    public static class LWorkerRepository
    {
        public static List<Worker> Workers { get; } = new List<Worker>
        {
            new Worker(1, "Leonenko Vladislava Urievna", 4,
                (from wc in LWorkerCategoryRepository.WorkerCategories where wc.Id == 4 select wc).First(),
                new DateTime(2022, 2, 15), 24, 1,
                (from pu in LProductionUnitRepository.ProductionUnits where pu.Id == 1 select pu).First()),

            new Worker(1, "Ermolenko Andrew Aleksandrovich", 5,
                (from wc in LWorkerCategoryRepository.WorkerCategories where wc.Id == 5 select wc).First(),
                new DateTime(2022, 1, 29), 39, 2,
                (from pu in LProductionUnitRepository.ProductionUnits where pu.Id == 2 select pu).First()),

            new Worker(1, "Dvornik Polina Dmitrievna", 2,
                (from wc in LWorkerCategoryRepository.WorkerCategories where wc.Id == 2 select wc).First(),
                new DateTime(2022, 4, 10), 20, 5,
                (from pu in LProductionUnitRepository.ProductionUnits where pu.Id == 5 select pu).First()),

            new Worker(1, "Fedorovich Anastasiya Dmitrievna", 2,
                (from wc in LWorkerCategoryRepository.WorkerCategories where wc.Id == 2 select wc).First(),
                new DateTime(2022, 2, 18), 11, 4,
                (from pu in LProductionUnitRepository.ProductionUnits where pu.Id == 4 select pu).First()),

            new Worker(1, "Lebedinskiy Vladislav Evgenievich", 3,
                (from wc in LWorkerCategoryRepository.WorkerCategories where wc.Id == 3 select wc).First(),
                new DateTime(2022, 2, 1), 32, 5,
                (from pu in LProductionUnitRepository.ProductionUnits where pu.Id == 5 select pu).First()),
        };
    }
}
