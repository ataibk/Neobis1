using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Automobile : Vehicle
    {
        public void debug()
        {
            Name = "BMW";
            Weight = "1500kg";
            averageSpeed = "320km/h";
            powerEngine = "900h/p";

            Console.WriteLine("Automobile:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Name);
            Console.WriteLine(Weight);
            Console.WriteLine(averageSpeed);
            Console.WriteLine(powerEngine);
            Console.ResetColor();
        }
    }
}
