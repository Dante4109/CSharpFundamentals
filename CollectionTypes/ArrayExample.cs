using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleFundies.DataStructues
{
    class ArrayExample
    {
        public static void PrintArrayExample()
        {
            var evenNums = new int[] { 2, 4, 6, 8, 10 };
            string[] cities = { "Mumbai", "London", "New York" };

            Console.WriteLine(evenNums[0]);  //prints 2
            Console.WriteLine(evenNums[1]);  //prints 4

            for (int i = 0; i < evenNums.Length; i++)
                Console.WriteLine(evenNums[i]);

            for (int i = 0; i < evenNums.Length; i++)
                evenNums[i] = evenNums[i] + 10;  // update the value of each element by 10

            foreach (var item in evenNums)
                Console.WriteLine(item);

            foreach (var city in cities)
                Console.WriteLine(city);
        }

        public static void PrintArrayLINQExample()
        {
            int[] nums = new int[5] { 10, 15, 16, 8, 6 };

            Console.WriteLine(nums.Max()); // returns 16
            Console.WriteLine(nums.Min()); // returns 6
            Console.WriteLine(nums.Sum()); // returns 55

            Array.Sort(nums); // sorts array 
            Array.Reverse(nums); // sorts array in descending order
            Array.ForEach(nums, n => Console.WriteLine(n)); // iterates array
            Array.BinarySearch(nums, 5);// binary search 
        }
    }
}
