using System;

namespace Task2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of product:");
            int number = Convert.ToInt32(Console.ReadLine());
            int CountOfProducts;
            double total;

            switch (number)
            {
                case 0:
                break;

                case 1:
                    Console.WriteLine("#1\n Choose amount of product:");
                    CountOfProducts = Convert.ToInt32(Console.ReadLine());
                    total = 4 * CountOfProducts;
                    Console.WriteLine($"Total: R$ {total}");
                    Console.WriteLine("Press any key to exit");
                    break;

                case 2:
                    Console.WriteLine("#2\n Choose amount of product:");
                    CountOfProducts = Convert.ToInt32(Console.ReadLine());
                    total = 4.50 * CountOfProducts;
                    Console.WriteLine($"Total: R$ {total}");
                    Console.WriteLine("Press any key to exit");
                    break;

                case 3:
                    Console.WriteLine("#3\n Choose amount of product:");
                    CountOfProducts = Convert.ToInt32(Console.ReadLine());
                    total = 5 * CountOfProducts;
                    Console.WriteLine($"Total: R$ {total}");
                    Console.WriteLine("Press any key to exit");
                    break;

                case 4:
                    Console.WriteLine("#4\n Choose amount of product:");
                    CountOfProducts = Convert.ToInt32(Console.ReadLine());
                    total = 2 * CountOfProducts;
                    Console.WriteLine($"Total: R$ {total}");
                    Console.WriteLine("Press any key to exit");
                    break;

                case 5:
                    Console.WriteLine("#5\n Choose amount of product:");
                    CountOfProducts = Convert.ToInt32(Console.ReadLine());
                    total = 1.50 * CountOfProducts;
                    Console.WriteLine($"Total: R$ {total}");
                    Console.WriteLine("Press any key to exit");
                    break;

                default:
                    Console.WriteLine("Nothing");
                    Console.WriteLine("Press any key to exit");
                    break;
                    
            }
            Console.ReadKey();
        }
       
    }
}
