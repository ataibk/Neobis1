using System;


namespace Task2_8
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter text from 1 to 500: ");
            string text = Console.ReadLine();
            if (text.Length >= 500 || text.Length <= 1)
            { }
            if (text.Length > 80)
            {
                Console.WriteLine("No");
            }
            else Console.WriteLine("Yes");
            Console.ReadKey();
        }
    }
}