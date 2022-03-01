using System;
using System.Collections.Generic;

namespace SalaryLibrary
{
    public static class Service
    {
        public static List<Worker> Workers { get; private set; }

        /// <summary>
        /// Reading from xml file
        /// </summary>
        /// <param name="filename">Name and place of file</param>
        public static void ReadXML(string filename)
        {
            Workers = XmlParser.Read(filename);
        }

        /// <summary>
        /// Saving info into xml file
        /// </summary>
        /// <param name="filename">Name and place of file</param>
        public static void SaveToXml(string filename)
        {
            XmlParser.Save(filename);
        }

        /// <summary>
        /// Getting full names of workers in list
        /// </summary>
        /// <returns>Array of full names</returns>
        public static string[] GetWorkersNames()
        {
            string[] names = new string[Workers.Count];

            for (int i = 0; i < names.Length; i++)
            {
                names[i] = Workers[i].FullName;
            }

            return names;
        }

        /// <summary>
        /// Getting workers attributes
        /// </summary>
        /// <returns>Array of attributes</returns>
        public static string[] GetWorkersAttributes()
        {
            return new string[]
            {
                "FullName", "TariffCategory", "BillingPeriodDate", "AmountOfWorkDone", "UnitCost"
            };
        }

        /// <summary>
        /// Changing some attribute of some worker
        /// </summary>
        /// <param name="fullName"></param>
        /// <param name="attribute"></param>
        /// <param name="newValue"></param>
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

        /// <summary>
        /// Setting tariff category
        /// </summary>
        /// <param name="category">String value of tariff category</param>
        /// <returns>TariffCategory object</returns>
        /// <exception cref="Exception"></exception>
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
