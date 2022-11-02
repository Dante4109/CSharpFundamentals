using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleFundies.DataStructues
{
    public enum Season
    {
        Spring,  //0
        Summer,  //1
        Autumn,  //2
        Winter   //3
    }

    public class EnumExample
    {
        public void PrintSeasonInfo()
        {
            Season a = Season.Autumn;
            Console.WriteLine($"Integral value of {a} is {(int)a}");  // output: Integral value of Autumn is 2

            var b = (Season)1;
            Console.WriteLine(b);  // output: Summer

            var c = (Season)4;
            Console.WriteLine(c);  // output: 4
        }
    }
}
