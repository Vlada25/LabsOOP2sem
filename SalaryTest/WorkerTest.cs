using Microsoft.VisualStudio.TestTools.UnitTesting;
using SalaryLibrary;
using System;

namespace SalaryTest
{
    [TestClass]
    public class WorkerTest
    {
        [TestMethod]
        [DataRow("Fedorovich Anastasiya Dmitrievna", TariffCategory.Other, "14.03.2022", 205, 21.3)]
        public void Constructor_Test(string fullName, TariffCategory tariffCategory, string dateStr, int amountOfWorkDone, double unitCount)
        {
            Worker worker = new Worker(fullName, tariffCategory, Convert.ToDateTime(dateStr), amountOfWorkDone, unitCount);

            Assert.AreEqual(fullName, worker.FullName);
            Assert.AreEqual(tariffCategory, worker.TariffCategory);
            Assert.AreEqual(Convert.ToDateTime(dateStr), worker.BillingPeriodDate);
            Assert.AreEqual(amountOfWorkDone, worker.AmountOfWorkDone);
            Assert.AreEqual(unitCount, worker.UnitCost);
        }

        [TestMethod]
        public void ParseDateToStr_Test()
        {
            Worker worker = new Worker(
                "Fedorovich Anastasiya Dmitrievna", 
                TariffCategory.Other, 
                new DateTime(2022, 3, 14), 
                205, 
                21.3);

            worker.ParseDateToStr();

            string expected = "14.03.2022";

            Assert.AreEqual(expected, worker.DateToStr);
        }
    }
}
