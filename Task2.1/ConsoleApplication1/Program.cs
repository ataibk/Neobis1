using System;

namespace Task2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Количество рабочих:");
            int NoW = int.Parse(Console.ReadLine());

            Console.WriteLine("Количество рабочих часов в 1 месяце:");
            int HfM = int.Parse(Console.ReadLine());

            Console.WriteLine("Зарплата за час:");
            double PpH = double.Parse(Console.ReadLine());

            Console.WriteLine($"NUMBER = {NoW}");
            Console.WriteLine($"SALARY = {Salary(HfM, PpH)}");

            Console.ReadKey();
        }
        static double Salary(int a, double b)
        {
            double c = a * b;
            return c;
        }
    }
}