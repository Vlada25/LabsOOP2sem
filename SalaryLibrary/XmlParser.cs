using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Schema;

namespace SalaryLibrary
{
    internal class XmlParser
    {
        /// <summary>
        /// Validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="v"></param>
        /// <exception cref="Exception"></exception>
        static void ValidationEventHandler(object sender, ValidationEventArgs v)
        {
            if (v.Severity == XmlSeverityType.Warning)
                throw new Exception("Warning: " + v.Message);
            else if (v.Severity == XmlSeverityType.Error)
                throw new Exception("Error: " + v.Message);
        }

        /// <summary>
        /// Reading from xml file
        /// </summary>
        /// <param name="filename">Name of file</param>
        /// <returns>List of workers</returns>
        public static List<Worker> Read(string filename)
        {
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.Schemas.Add("", @"E:\Лабы\2курс\ООП\LabsOOP2sem\SalaryLibrary\XMLSchema.xsd");
            settings.ValidationType = ValidationType.Schema;
            settings.ValidationEventHandler += new ValidationEventHandler(ValidationEventHandler);

            List<Worker> workerList = new List<Worker>();
            XmlReader xmlReader = XmlReader.Create(filename);

            while (xmlReader.Read())
            {
                if (xmlReader.NodeType == XmlNodeType.Element)
                {
                    if (xmlReader.HasAttributes)
                    {
                        string fullName = xmlReader.GetAttribute("fullName");
                        TariffCategory tariffCategory = Service.SetTariffCategory(xmlReader.GetAttribute("tariffCategory"));
                        DateTime billingPeriodDate = Convert.ToDateTime(xmlReader.GetAttribute("billingPeriodDate"));
                        int amountOfWorkDone = Convert.ToInt32(xmlReader.GetAttribute("amountOfWorkDone"));
                        double unitCost = Convert.ToDouble(xmlReader.GetAttribute("unitCost"));

                        workerList.Add(new Worker(
                            fullName,
                            tariffCategory,
                            billingPeriodDate,
                            amountOfWorkDone,
                            unitCost));
                    }
                }
            }

            return workerList;
        }

        /// <summary>
        /// Saving info into file
        /// </summary>
        /// <param name="filename">Name of file</param>
        public static void Save(string filename)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(filename);

            XmlElement xRoot = xDoc.DocumentElement;
            xRoot.RemoveAll();

            foreach (Worker worker in Service.Workers)
            {
                XmlElement workerElem = xDoc.CreateElement("worker");

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
    }
}
