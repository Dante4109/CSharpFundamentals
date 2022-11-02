using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleFundies.Abstraction
{
    // Interface
    interface IAnimal
    {
        void animalSound(); // interface method (does not have a body)
    }

    // Cat and Dog both "implement" the IAnimal interface
    class Cat : IAnimal
    {
        public void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The cat says: Meow");
        }
    }

    class Dog : IAnimal
    {
        public void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The dog says: Woof");
        }
    }
}
