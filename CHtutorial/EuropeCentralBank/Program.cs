using System;
using System.Globalization;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace EuropeCentralBank
{
    class Program
    {
        static void Main(string[] args)
        {

             
            XmlReader xmlReader = XmlReader.Create("http://www.ecb.int/stats/eurofxref/eurofxref-daily.xml");
                while (xmlReader.Read())
                {   if (xmlReader.GetAttribute("currency") == "PLN") 
                            Console.WriteLine(xmlReader.GetAttribute("currency") + ": " + xmlReader.GetAttribute("rate"));
                    
                }
                Console.ReadKey();

                CultureInfo usCulture = new CultureInfo("en-US");
            XDocument xDoc = XDocument.Load("http://www.ecb.europa.eu/stats/eurofxref/eurofxref-daily.xml");
            var cubeNodes = xDoc.Descendants().Where(n => n.Name.LocalName == "Cube" && n.Attribute("currency") != null).ToList();
            var currencyRateItems = cubeNodes.Select(node => new
            {
                Currency = node.Attribute("currency").Value,
                Rate = double.Parse(node.Attribute("rate").Value, plCulture)
            });


            int pageSize = 10, pageCounter = 0;
            var pageItems = currencyRateItems.Take(pageSize);
            while (pageItems.Count() > 0)
            {
                foreach (var item in pageItems)
                    Console.WriteLine(item.Currency + ": " + item.Rate.ToString("N2", usCulture));
                Console.WriteLine("Press any key to get the next items...");
                Console.ReadKey();
                pageCounter++;
                // Here's where we use the Skip() and Take() methods!
                pageItems = currencyRateItems.Skip(pageSize * pageCounter).Take(pageSize);
            }
            Console.WriteLine("Done!");

        }
    }
}