using System;

namespace SalaryLibrary
{
    public class Worker
    {
        public string FullName { get; set; }
        public TariffCategory TariffCategory { get; set; }
        public DateTime BillingPeriodDate { get; set; }
        public int AmountOfWorkDone { get; set; }
        public double UnitCost { get; set; }
        public string DateToStr { get; private set; }

        public Worker() { }
        public Worker(
            string fullName, 
            TariffCategory tariffCategory, 
            DateTime billingPeriodDate,
            int amountOfWorkDone,
            double unitCost
            )
        {
            FullName = fullName;
            TariffCategory = tariffCategory;
            BillingPeriodDate = billingPeriodDate;
            AmountOfWorkDone = amountOfWorkDone;
            UnitCost = unitCost;
            ParseDateToStr();
        }

        public void ParseDateToStr()
        {
            DateToStr = BillingPeriodDate.ToString("d");
        }

        public override string ToString()
        {
            return $"Full name: {FullName}; Tarif category: {TariffCategory}; Date: {BillingPeriodDate}";
        }
    }
}
