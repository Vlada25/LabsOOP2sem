using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryManager.DAL.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        IProductionUnitRepository ProductionUnit { get; }
        IWorkerRepository Worker { get; }
        IWorkerCtegoryRepository WorkerCtegory { get; }
    }
}
