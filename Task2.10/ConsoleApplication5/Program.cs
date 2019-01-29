using System;
using System.Linq;
using System.Threading;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)

            { 
            Console.Write("Enter the number of repetitions: ");

            int size = int.Parse(Console.ReadLine());

            if (size >= 2000 || size <= 0)
            {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nYour number must not be less than 0 or more than 2000!");
                    System.Threading.Thread.Sleep(2500);
                    break;
                
                
                }
                for (int j = 0; j < size; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Insert your number: ");

                    int leds = 0;
                    string input = Console.ReadLine();
                    {
                    }
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (input[i] == '\0') break;
                        if (input[i] == '1') leds += 2;
                        if (input[i] == '2') leds += 5;
                        if (input[i] == '3') leds += 5;
                        if (input[i] == '4') leds += 4;
                        if (input[i] == '5') leds += 5;
                        if (input[i] == '6') leds += 6;
                        if (input[i] == '7') leds += 3;
                        if (input[i] == '8') leds += 7;
                        if (input[i] == '9') leds += 6;
                        if (input[i] == '0') leds += 6;
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{leds} leds");
                }
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}