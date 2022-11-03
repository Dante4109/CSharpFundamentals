using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleFundies.Exercises
{
    class IntToString
    {
        public string intToString(int i)
        {
            StringBuilder b = new StringBuilder();

            while (i != 0)
            {
                b.insert(0, (char)('0' + i % 10));
                i /= 10;
            }

            return b.toString();
        }
    }
}
