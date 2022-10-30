using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Replicator_of_D_To
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = new int[5];
            int[] secondArray = new int[5];

            for(int i = 0; i < firstArray.Length; i++)
            {
                Console.Write($"Enter a number to store in spot {i} of the firstArray ");
                firstArray[i] = Int32.Parse(Console.ReadLine());
            }

            for(int i = 0; i < secondArray.Length; i++)
            {
                secondArray[i] = firstArray[i];
            }

            for(int i = 0; i < firstArray.Length; i++)
            {
                Console.WriteLine($"Spot #{i} in the first array is {firstArray[i]}");
                Console.WriteLine($"Spot #{i} in the second array is {secondArray[i]}");
            }
        }
    }
}
