using System;
using System.Collections.Generic;
using System.Xml;

namespace SalaryLibrary
{
    public static class Service
    {
        public static List<Worker> Workers { get; private set; }

        public static void ReadXML(string filename)
        {
            Workers = XmlParser.Read(filename);
            
        }

        public static void SaveToXml(string filename)
        {
            XmlParser.Save(filename);
        }
        public static string[] GetWorkersNames()
        {
            string[] names = new string[Workers.Count];

            for (int i = 0; i < names.Length; i++)
            {
                names[i] = Workers[i].FullName;
            }

            return names;
        }

        public static string[] GetWorkersAttributes()
        {
            return new string[]
            {
                "FullName", "TariffCategory", "BillingPeriodDate", "AmountOfWorkDone", "UnitCost"
            };
        }

        public static void ChangeSomeValue(string fullName, string attribute, string newValue)
        {
            int index = 0;

            for (int i = 0; i < Workers.Count; i++)
            {
                if (Workers[i].FullName == fullName)
                {
                    index = i;
                    break;
                }
            }

            switch (attribute)
            {
                case "FullName":
                    Workers[index].FullName = newValue;
                    break;
                case "TariffCategory":
                    Workers[index].TariffCategory = SetTariffCategory(newValue);
                    break;
                case "BillingPeriodDate":
                    Workers[index].BillingPeriodDate = Convert.ToDateTime(newValue);
                    Workers[index].ParseDateToStr();
                    break;
                case "AmountOfWorkDone":
                    Workers[index].AmountOfWorkDone = Convert.ToInt32(newValue);
                    break;
                case "UnitCost":
                    Workers[index].UnitCost = Convert.ToDouble(newValue);
                    break;
            }
        }

        internal static TariffCategory SetTariffCategory(string category)
        {
            if (!Enum.TryParse(category, out TariffCategory tariffCategory))
            {
                throw new Exception("This category does not exist");
            }
            return tariffCategory;
        }
    }
}
