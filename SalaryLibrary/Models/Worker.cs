using System;

namespace SalaryLibrary.Models
{
    public class Worker
    {
        public string FullName { get; set; }
        public TariffCategory TariffCategory { get; set; }
        public DateTime BillingPeriodDate { get; set; }
        public int AmountOfWorkDone { get; set; }
        public double UnitCost { get; set; }
        public string DateToStr { get; private set; }

        /// <summary>
        /// Empty constructor
        /// </summary>
        public Worker() { }

        /// <summary>
        /// Constructor with params
        /// </summary>
        /// <param name="fullName"></param>
        /// <param name="tariffCategory"></param>
        /// <param name="billingPeriodDate"></param>
        /// <param name="amountOfWorkDone"></param>
        /// <param name="unitCost"></param>
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

        /// <summary>
        /// Parsing BillingPeriodDate from DateTime to string
        /// </summary>
        public void ParseDateToStr()
        {
            DateToStr = BillingPeriodDate.ToString("d");
        }

        /// <summary>
        /// Getting the string representation of object Worker
        /// </summary>
        /// <returns>Info about worker</returns>
        public override string ToString()
        {
            return $"Full name: {FullName}; Tarif category: {TariffCategory}; Date: {BillingPeriodDate}";
        }
    }
}
