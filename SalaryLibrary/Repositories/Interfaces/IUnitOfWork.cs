namespace SalaryManager.DAL.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        IProductionUnitRepository ProductionUnit { get; }
        IWorkerRepository Worker { get; }
        IWorkerCtegoryRepository WorkerCategory { get; }
    }
}
