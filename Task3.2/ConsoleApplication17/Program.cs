using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Write("Выберите валюту:\n$(1)\n€(2)\n£(3)\n¥(4)\n₽(5)\n");
            int number = int.Parse(Console.ReadLine());
            string sum;


            switch (number)
            {
                case 1:
                    Console.Clear();
                    string Valuta = "$";
                    Console.Write('$');
                    sum = Console.ReadLine();
                    string[] Arr1 = { Valuta, sum};
                    Console.WriteLine(extractCurrencyValue(Arr1, Valuta));
                    break;

                case 2:
                    Console.Clear();
                    Valuta = "€";
                    Console.Write('€');
                    sum = Console.ReadLine();
                    string[] Arr2 = { Valuta, sum };
                    Console.WriteLine(extractCurrencyValue(Arr2, Valuta));
                    break;

                case 3:
                    Console.Clear();
                    Valuta = "£";
                    Console.Write('£');
                    sum = Console.ReadLine();
                    string[] Arr3 = { Valuta, sum };
                    Console.WriteLine(extractCurrencyValue(Arr3, Valuta));
                    break;

                case 4:
                    Console.Clear();
                    Valuta = "¥";
                    Console.Write('¥');
                    sum = Console.ReadLine();
                    string[] Arr4 = { Valuta, sum };
                    Console.WriteLine(extractCurrencyValue(Arr4, Valuta));
                    break;

                case 5:
                    Console.Clear();
                    Valuta = "₽";
                    Console.Write('₽');
                    sum = Console.ReadLine();
                    string[] Arr5 = { Valuta, sum };
                    Console.WriteLine(extractCurrencyValue(Arr5, Valuta));
                    break;
            }
            

            Console.ReadKey();

        }
            static string extractCurrencyValue(string[] a, string valuta)
            {
                if (a[0] == valuta)
                {
                    a[0].TrimStart();
                    return a[1];
                }
                return " ";

            }
        }
    }