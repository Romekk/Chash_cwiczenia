using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            try
            {
                int[] numbers = new int[2];

                numbers[0] = 23;
                Console.WriteLine(numbers[0]);
                numbers[1] = 32;
                Console.WriteLine(numbers[1]);
                numbers[2] = 42;
                Console.WriteLine(numbers[2]);

                foreach (int i in numbers)
                    Console.WriteLine(i);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Wystąpił następujący błąd: " + ex.Message);
            }
        }
    }
}
