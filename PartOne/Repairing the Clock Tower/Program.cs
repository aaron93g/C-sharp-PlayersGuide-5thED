using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repairing_the_Clock_Tower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int userNumber = Int32.Parse(Console.ReadLine());

            if (userNumber % 2 == 0) Console.WriteLine("Tick");

            if (userNumber % 2 != 0) Console.WriteLine("Tock");
        }
    }
}
