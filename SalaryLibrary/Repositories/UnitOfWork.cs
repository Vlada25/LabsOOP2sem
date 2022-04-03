using SalaryManager.DAL.Repositories.Interfaces;

namespace SalaryManager.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public IProductionUnitRepository ProductionUnit => new ProductionUnitRepository();

        public IWorkerRepository Worker => new WorkerRepository();

        public IWorkerCtegoryRepository WorkerCategory => new WorkerCategoryRepository();
    }
}
