using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watch_Tower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int xAxis = Int32.Parse(Console.ReadLine());
            int yAxis = Int32.Parse(Console.ReadLine());

            if (xAxis == 0 || yAxis == 0)
            {
                Console.WriteLine("The enemy is here");
            }
            else if (xAxis < 0 && yAxis < 0)
            {
                Console.WriteLine("enemy SW");
            }
            else if (yAxis < 0 && xAxis > 0)
            {
                Console.WriteLine("enemy SE");
            }
            else if (xAxis > 0 && yAxis > 0)
            {
                Console.WriteLine("enemy NE");
            }
            else if (xAxis > 0 && yAxis == 0)
            {
                Console.WriteLine("enemy E");
            }
            else if(xAxis < 0 && yAxis == 0)
            {
                Console.WriteLine("W");
            }
            else if(xAxis < 0 && yAxis > 0)
            {
                Console.WriteLine("enemy NW");
            }
            else if(xAxis == 0 && yAxis > 0)
            {
                Console.WriteLine("enemy N");
            }
            else if(xAxis == 0 && yAxis < 0)
            {
                Console.WriteLine("enemy S");
            }
        }
    }
}
