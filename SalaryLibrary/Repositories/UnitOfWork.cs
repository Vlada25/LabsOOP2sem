using SalaryManager.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryManager.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public IProductionUnitRepository ProductionUnit => new ProductionUnitRepository(); 

        public IWorkerRepository Worker => new WorkerRepository();

        public IWorkerCtegoryRepository WorkerCtegory => new WorkerCategoryRepository();
    }
}
