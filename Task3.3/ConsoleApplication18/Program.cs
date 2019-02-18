using System;
using System.Threading;

namespace lab3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Введите количество повторений");
            a = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Red;
            for (int b = 0; b < a; b++)
            {
                for (int i = 0; i <= 4; i++)
                {
                    if (i == 1) Console.WriteLine("*");
                    Thread.Sleep(50);
                    if (i == 2) Console.WriteLine("**");
                    Thread.Sleep(50);
                    if (i == 3) Console.WriteLine("***");
                    Thread.Sleep(50);
                    if (i == 4) Console.WriteLine("****");
                    Thread.Sleep(50);
                }
                for (int i = 4; i >= 0; i--)
                {
                    if (i == 1) Console.WriteLine("*");
                    Thread.Sleep(50);
                    if (i == 2) Console.WriteLine("**");
                    Thread.Sleep(50);
                    if (i == 3) Console.WriteLine("***");
                    Thread.Sleep(50);
                    if (i == 4) Console.WriteLine("****");
                    Thread.Sleep(50);
                }
            }
            Thread.Sleep(2550);
        }
    }
}
