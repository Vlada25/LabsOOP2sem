using SalaryManager.DAL.Models;
using System.Collections.Generic;

namespace SalaryLibrary.Repositories.LocalRepositories
{
    public static class LWorkerCategoryRepository
    {
        public static List<WorkerCategory> WorkerCategories { get; } = new List<WorkerCategory>
        {
            new WorkerCategory(1, "First", 0.1),
            new WorkerCategory(2, "Second", 0.15),
            new WorkerCategory(3, "Third", 0.2),
            new WorkerCategory(4, "Middle engeneer", 0.225),
            new WorkerCategory(5, "Senior engeneer", 0.25)
        };
    }
}
