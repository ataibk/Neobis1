using System;


namespace Task2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите а: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите b: ");
            int b = Convert.ToInt32(Console.ReadLine());
   
            Console.Write("Введите c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine($"{a} eh o maior");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine($"{b} eh o maior");
            }
            else
            {
                Console.WriteLine($"{c} eh o maior");
            }
            double MaiorAB = (a + b + Math.Abs(a - b)) / 2;

            Console.WriteLine($"{MaiorAB} ");
            Console.ReadKey();
        }
    }
}