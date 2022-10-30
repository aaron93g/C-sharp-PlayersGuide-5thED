using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace playersGuideNestingLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pilotNumber;
            int hunterNumber;

            Console.Write("Enter a number ");
            pilotNumber = Int32.Parse(Console.ReadLine());

            while (pilotNumber < 0 || pilotNumber > 100) // LOOP UNTIL AUTHORIZED NUMBER ENTERED
            {
                Console.Write("Enter a number between 0 and 100 ");
                pilotNumber = Int32.Parse(Console.ReadLine());
            }

            Console.Clear();

            Console.Write("Hunter, guess a number. ");
            hunterNumber = Int32.Parse(Console.ReadLine());

            while (hunterNumber != pilotNumber)
            {
                if (hunterNumber > pilotNumber)
                {
                    Console.WriteLine(hunterNumber + " is too high.");
                    Console.Write("What is your next guess? ");
                    hunterNumber = Int32.Parse(Console.ReadLine());
                }
                else if (hunterNumber < pilotNumber)
                {
                    Console.WriteLine(hunterNumber + " is too low.");
                    Console.Write("What is your next guess? ");
                    hunterNumber = Int32.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("You guessed the number!");
    }   }
}
