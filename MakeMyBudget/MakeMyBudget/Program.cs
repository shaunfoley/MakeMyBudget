using BudgetCore;
using Newtonsoft.Json;
using System;
using System.Xml;

namespace MakeMyBudget
{
    class Program
    {
        static void Main(string[] args)
        {
            string xml = System.IO.File.ReadAllText(@"D:\Downloads\FinanceData.xml");
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            string json = JsonConvert.SerializeXmlNode(doc);

            Root ConvertedJson = JsonConvert.DeserializeObject<Root>(json);

            Console.WriteLine(JsonConvert.SerializeObject(ConvertedJson));
        }
    }
} 