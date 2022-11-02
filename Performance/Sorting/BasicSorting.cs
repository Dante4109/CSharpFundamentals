using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleFundies.Performance.Sorting
{
    public class BasicSorting
    {
        public void PrintSortedArray()
        {
            // Array of integers
            int[] intArray = new int[] {
            9,
            2,
            4,
            3,
            1,
            5
        };

            Console.WriteLine("Original array");
            foreach (int i in intArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            // Sort array in ASC order
            Console.WriteLine("Sorted array in ASC order");
            Array.Sort(intArray);
            foreach (int i in intArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Sorted array in DESC order");
            // Sort Array in DESC order
            Array.Reverse(intArray);
            foreach (int i in intArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
