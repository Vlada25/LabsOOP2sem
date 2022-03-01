using Microsoft.VisualStudio.TestTools.UnitTesting;
using SalaryLibrary;

namespace SalaryTest
{
    [TestClass]
    public class SalaryServiceTest
    {
        [TestMethod]
        public void ReadXML_Test()
        {
            Service.ReadXML(@"..\data.xml");

            int expected = 3;

            Assert.AreEqual(expected, Service.Workers.Count);
        }

        [TestMethod]
        public void GetWorkersNames_Test()
        {
            Service.ReadXML(@"..\data.xml");

            string expected = "Dvornik Polyna Dmitrievna";

            Assert.AreEqual(expected, Service.GetWorkersNames()[1]);
        }

        [TestMethod]
        public void GetWorkersAttributes_Test()
        {
            string expected = "AmountOfWorkDone";

            Assert.AreEqual(expected, Service.GetWorkersAttributes()[3]);
        }

        [TestMethod]
        [DataRow("Leonenko Vladislava Urievna", "UnitCost", "100")]
        public void ChangeSomeValue_Test(string name, string attribute, string attrValue)
        {
            Service.ReadXML(@"..\data.xml");
            Service.ChangeSomeValue(name, attribute, attrValue);

            double expected = 100;

            Assert.AreEqual(expected, Service.Workers[0].UnitCost);
        }
    }
}
