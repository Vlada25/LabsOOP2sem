namespace SalaryManager.DAL.Models
{
    public class WorkerCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double TariffCoefficient { get; set; } // процент к зарплате в зависимости от категории

        public WorkerCategory(int id, string name, double tariffCoefficient)
        {
            Id = id;
            Name = name;
            TariffCoefficient = tariffCoefficient;
        }

    }
}
