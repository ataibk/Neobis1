using System;

namespace Task2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert X");
            int x = int.Parse(Console.ReadLine());
            if (x >= 1 && x <= 1000)
            {
                for (int i = 0; i <= x; i++)
                {
                    if (i % 2 == 1)
                    {
                        Console.WriteLine(i);
                    }
                }
             }
            Console.ReadKey();
        }
    }
}