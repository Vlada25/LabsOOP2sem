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
            Workers = new List<Worker>();
            XmlReader xmlReader = XmlReader.Create(filename);

            while (xmlReader.Read())
            {
                if (xmlReader.NodeType == XmlNodeType.Element)
                {
                    if (xmlReader.HasAttributes)
                    {
                        string fullName = xmlReader.GetAttribute("fullName");
                        TariffCategory tariffCategory = SetTariffCategory(xmlReader.GetAttribute("tariffCategory"));
                        DateTime billingPeriodDate = Convert.ToDateTime(xmlReader.GetAttribute("billingPeriodDate"));
                        int amountOfWorkDone = Convert.ToInt32(xmlReader.GetAttribute("amountOfWorkDone"));
                        double unitCost = Convert.ToDouble(xmlReader.GetAttribute("unitCost"));

                        Workers.Add(new Worker(
                            fullName, 
                            tariffCategory, 
                            billingPeriodDate, 
                            amountOfWorkDone, 
                            unitCost));
                    }
                }
            }
        }

        public static void SaveToXml(string filename)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(filename);

            XmlElement xRoot = xDoc.DocumentElement;
            xRoot.RemoveAll();

            foreach (Worker worker in Workers)
            {
                XmlElement workerElem = xDoc.CreateElement("workers");

                XmlAttribute fullNameAttr = xDoc.CreateAttribute("fullName");
                XmlAttribute tariffCategoryAttr = xDoc.CreateAttribute("tariffCategory");
                XmlAttribute billingPeriodDateAttr = xDoc.CreateAttribute("billingPeriodDate");
                XmlAttribute amountOfWorkDoneAttr = xDoc.CreateAttribute("amountOfWorkDone");
                XmlAttribute unitCostAttr = xDoc.CreateAttribute("unitCost");

                XmlText fullNameText = xDoc.CreateTextNode(worker.FullName);
                XmlText tariffCategoryText = xDoc.CreateTextNode(worker.TariffCategory.ToString());
                XmlText billingPeriodDateText = xDoc.CreateTextNode(worker.DateToStr);
                XmlText amountOfWorkDoneText = xDoc.CreateTextNode(worker.AmountOfWorkDone.ToString());
                XmlText unitCostText = xDoc.CreateTextNode(worker.UnitCost.ToString());

                fullNameAttr.AppendChild(fullNameText);
                tariffCategoryAttr.AppendChild(tariffCategoryText);
                billingPeriodDateAttr.AppendChild(billingPeriodDateText);
                amountOfWorkDoneAttr.AppendChild(amountOfWorkDoneText);
                unitCostAttr.AppendChild(unitCostText);

                workerElem.Attributes.Append(fullNameAttr);
                workerElem.Attributes.Append(tariffCategoryAttr);
                workerElem.Attributes.Append(billingPeriodDateAttr);
                workerElem.Attributes.Append(amountOfWorkDoneAttr);
                workerElem.Attributes.Append(unitCostAttr);

                xRoot.AppendChild(workerElem);
            }

            xDoc.Save(filename);
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

        private static TariffCategory SetTariffCategory(string category)
        {
            if (!Enum.TryParse(category, out TariffCategory tariffCategory))
            {
                throw new Exception("This category does not exist");
            }
            return tariffCategory;
        }
    }
}
