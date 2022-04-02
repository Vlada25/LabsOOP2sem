using System;

namespace SalaryManager.DAL.Models
{
    public class Worker
    {
        public string FullName { get; set; }
        public WorkerCategory TariffCategory { get; set; }
        public DateTime BillingPeriodDate { get; set; }
        public int AmountOfWorkDone { get; set; }
        public ProductionUnit ProductionUnit { get; set; }

        public Worker() { }

        public Worker(
            string fullName,
            WorkerCategory tariffCategory,
            DateTime billingPeriodDate,
            int amountOfWorkDone,
            ProductionUnit productionUnit
            )
        {
            FullName = fullName;
            TariffCategory = tariffCategory;
            BillingPeriodDate = billingPeriodDate;
            AmountOfWorkDone = amountOfWorkDone;
            ProductionUnit = productionUnit;
        }

        /// <summary>
        /// Parsing BillingPeriodDate from DateTime to string
        /// </summary>
        public string GetStrDate()
        {
            return $"{BillingPeriodDate.Year}-{BillingPeriodDate.Month}-{BillingPeriodDate.Day}";
        }

        public override string ToString()
        {
            return $"Full name: {FullName}; Tarif category: {TariffCategory}; Date: {BillingPeriodDate}";
        }
    }
}
