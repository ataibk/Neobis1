using System;
using System.Threading;

namespace Task2_5
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[11];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-100, 100);
                Console.WriteLine($"X[{i}] {array[i]}");
                if (array[i] <= 0)
                {
                    array[i] = 1;
                }
                Console.Write("{0,1}\b\b\b", i);
                Thread.Sleep(500);
            }
            Console.WriteLine("Without Negative:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"X[{i}] {array[i]}");
                if (array[i] <= 0)
                {
                    array[i] = 1;
                }
                
                Console.Write("{0,1}\b\b\b", i);
                Thread.Sleep(500);
                
            }
            Console.ReadKey();
        }
    }
}