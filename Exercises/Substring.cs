using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleFundies.Exercises
{
    class Substring
    {
        public static bool CheckForSubString(string str, string subString)
        {
            return str.Contains(subString) ? true : false; 
        }

        public static bool CheckForSubStringOld(string str, string subString)
        {
            return str.Contains(subString) ? true : false;
        }
    }
}
