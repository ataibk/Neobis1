using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            Console.Write("\nВведите макисмальную длину строки: ");
            int maxlength = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(truncate(str, maxlength));

            Console.ReadKey();
        }
        static string truncate(string a, int b)
        {
            string str;
            if (a.Length > b)
            {

                str = a.Remove(b - 3);

                return str + "...";
            }
            return a;
        }
    }
}