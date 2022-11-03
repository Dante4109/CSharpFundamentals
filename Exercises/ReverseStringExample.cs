using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleFundies.Exercises
{
    class ReverseStringExample
    {
        public string ReverseString(string str)
        {
            char[] cArray = str.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }

        public string ReverseStringLibrary(string str)
        {
            int testInt = 32;
            string testString = testInt.ToString();
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
