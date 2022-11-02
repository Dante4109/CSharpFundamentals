using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleFundies.DataStructues
{
    class TupleExample
    {

        public void PrintTupleExamples()
        {
            // Standard way
            Tuple<int, string, string> personOne =
            new Tuple<int, string, string>(1, "Steve", "Jobs");

            Console.WriteLine(personOne);

            // Dynamic
            var personTwo = Tuple.Create(2, "Steve", "Wozniak");

            Console.WriteLine(personTwo);

            //A tuple can only include a maximum of eight elements. It gives a compiler error when you try to include more than eight elements.

            ValueTuple<int, string, string> personThree = (3, "Bill", "Gates");
            Console.WriteLine(personThree.Item1);  // returns 3
            Console.WriteLine(personThree.Item2);   // returns "Bill"
            Console.WriteLine(personThree.Item3);   // returns "Gates"
        }
    }
}
