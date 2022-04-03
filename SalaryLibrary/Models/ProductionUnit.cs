namespace SalaryManager.DAL.Models
{
    public class ProductionUnit
    {
        public int Id { get; set; }
        public string UnitName { get; set; }
        public decimal Price { get; set; }

        public ProductionUnit(int id, string name, decimal price)
        {
            Id = id;
            UnitName = name;
            Price = price;
        }

    }
}
