﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleFundies.Performance.Sorting
{
    public class InsertionSort
    {

        // Function to sort array
        // using insertion sort
        public int[] Sort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                // Move elements of arr[0..i-1],
                // that are greater than key,
                // to one position ahead of
                // their current position
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }

            return arr;
        }
    }
}
