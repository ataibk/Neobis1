using System;
using System.Threading;

namespace Task2_7

{
    class Program
    {
        static void Main(string[] args)
        {

            int n, x;

            while (true)
            {
                Console.Write("Введите число n: ");
                n = int.Parse(Console.ReadLine());
                
                if (n == 0) break;

                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= n; j++)
                    {
                       
                        x = i;
                        if (j < x) x = j;
                        if (n - i + 1 < x) x = n - i + 1;
                        if (n - j + 1 < x) x = n - j + 1;
                        Console.Write(x);
                        if (j < n) Console.Write(' ');
                        else Console.Write('\n');

                        Thread.Sleep(50); /*скорость*/

                    }
                    
                }
                Console.Write('\n');
            }
            
            Console.ReadKey();
        }
    }
}