using System;

namespace DebugTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int a = 5;
            int b = 2;
            int result = MakeComplicatedCalculation(a, b);
            Console.WriteLine(result);

            for (int i = 0; i < 10; i++)
                Console.WriteLine("i is " + i);
        }

        static int MakeComplicatedCalculation(int a, int b)
        {
            return a * b;
        }
    }


}
