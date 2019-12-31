using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace Culture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Current culture: " + CultureInfo.CurrentCulture.Name);
            Console.WriteLine(" ");
            Console.WriteLine("");
            Console.WriteLine("Hello my World!", " and other world");
            Console.WriteLine(" ");
            Console.WriteLine("");
            Console.ReadLine();
            CultureInfo[] cinfo = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            List<RegionInfo> kraje = new List<RegionInfo>();
            foreach (CultureInfo ci in cinfo)
            {
                RegionInfo region = new RegionInfo(ci.Name);
                kraje.Add(region);
                //Console.WriteLine("Display name: " + ci.EnglishName," Time format: ", ci.DateTimeFormat.ToString());
                Console.WriteLine(ci.DisplayName + " English name=" + ci.EnglishName + " Time format: "+ ci.DateTimeFormat.ToString());
            }

            for (int i = 0; i<kraje.Count; i++)
            {
                Console.WriteLine("   Name:                         {0}", kraje[i].Name);
                Console.WriteLine("   DisplayName:                  {0}", kraje[i].DisplayName);
                Console.WriteLine("   EnglishName:                  {0}", kraje[i].EnglishName);
                Console.WriteLine("   IsMetric:                     {0}", kraje[i].IsMetric);
                Console.WriteLine("   ThreeLetterISORegionName:     {0}", kraje[i].ThreeLetterISORegionName);
                Console.WriteLine("   ThreeLetterWindowsRegionName: {0}", kraje[i].ThreeLetterWindowsRegionName);
                Console.WriteLine("   TwoLetterISORegionName:       {0}", kraje[i].TwoLetterISORegionName);
                Console.WriteLine("   CurrencySymbol:               {0}", kraje[i].CurrencySymbol);
                Console.WriteLine("   ISOCurrencySymbol:            {0}", kraje[i].ISOCurrencySymbol);
                Console.WriteLine(i);
                Thread.Sleep(i);
            }
            
        }
    }
}
