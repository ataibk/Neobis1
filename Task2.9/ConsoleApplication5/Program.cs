using System;
using System.Linq;
using System.Collections;



namespace Task2_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string response = "";
            Console.WriteLine("Press any key to start.");
            Console.ReadLine();
            int R, G, B;
            Console.Write("Choose: \nMin(1) | Mean(2) | Eye(3) | Exit(4)\n");
            
            
            bool starting = false;
            bool exiting = false;

            response = Console.ReadLine();

            while (response != "")
            {
                switch (response)
                {
                    case "min":
                    case "Min":
                    case "1":
                        Console.WriteLine("\nYou choose Min");
                        Console.Write("R = ");
                        R = Convert.ToInt32(Console.ReadLine());
                        Console.Write("G = ");
                        G = Convert.ToInt32(Console.ReadLine());
                        Console.Write("B = ");
                        B = Convert.ToInt32(Console.ReadLine());

                        if (R < G && R < B)
                        {
                            Console.WriteLine($"Caso #1: {R}");
                        }
                        else if (G < R && G < B)
                        {
                            Console.WriteLine($"Caso #1: {G}");
                        }
                        else
                        {
                            Console.WriteLine($"Caso #1: {B}");
                        }
                        Console.WriteLine();
                        Console.ReadLine();
                        Console.Clear();

                        break;

                    case "mean":
                    case "Mean":
                    case "2":
                        Console.WriteLine("\nYou choose Mean");
                        Console.Write("R = ");
                        R = Convert.ToInt32(Console.ReadLine());
                        Console.Write("G = ");
                        G = Convert.ToInt32(Console.ReadLine());
                        Console.Write("B = ");
                        B = Convert.ToInt32(Console.ReadLine());

                        if (R < G && R < B)
                        {
                            Console.WriteLine($"Caso #2: {R}");
                        }
                        else if (G < R && G < B)
                        {
                            Console.WriteLine($"Caso #2: {G}");
                        }
                        else
                        {
                            Console.WriteLine($"Caso #2: {B}");
                        }
                        Console.WriteLine();
                        Console.ReadLine();
                        Console.Clear();

                        break;

                    case "eye":
                    case "Eye":
                    case "3":
                        Console.WriteLine("\nYou choose Eye");
                        Console.Write("R = ");
                        R = Convert.ToInt32(Console.ReadLine());
                        Console.Write("G = ");
                        G = Convert.ToInt32(Console.ReadLine());
                        Console.Write("B = ");
                        B = Convert.ToInt32(Console.ReadLine());

                        if (R < G && R < B)
                        {
                            Console.WriteLine($"Caso #3: {R}");
                        }
                        else if (G < R && G < B)
                        {
                            Console.WriteLine($"Caso #3: {G}");
                        }
                        else
                        {
                            Console.WriteLine($"Caso #3: {B}");
                        }
                        Console.WriteLine();
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case "Exit":
                    case "4":
                        Console.WriteLine("\nGood Bye!");
                        System.Threading.Thread.Sleep(1000);
                        exiting = true;
                        break;
                        
                }

                if (starting || exiting)
                {
                    break;
                }
                else
                {
                    
                }

            }

            
        }
    }
}