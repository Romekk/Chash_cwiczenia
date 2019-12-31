using System;
using System.Collections.Generic;
using System.Linq;

namespace LinQSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>()
            {1, 7, 2, 61, 14};
            List<int> sortedNumbers = numbers.OrderBy(number => number).ToList();
            foreach (int number in sortedNumbers)
                Console.WriteLine(number);

            List<string> cityNames = new List<string>()
            {  "Amsterdam", "Berlin", "London", "New York"};
            List<string> sortedCityNames = cityNames.OrderBy(city => city).ToList();
            foreach (string cityName in sortedCityNames)
                Console.WriteLine(cityName);


            Console.WriteLine("Hello World!");
        }
    }
}
