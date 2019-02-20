using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Airplane : Vehicle
    {
        public void debug()
        {
            Name = "Boeing";
            Weight = "500t";
            averageSpeed = "950km/h";
            powerEngine = "2000h/p";

            Console.WriteLine("\nAirplane:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Name);
            Console.WriteLine(Weight);
            Console.WriteLine(averageSpeed);
            Console.WriteLine(powerEngine);
            Console.ResetColor();
        }
    }
}
