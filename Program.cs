using System;
using System.Collections.Generic;
using ConsoleFundies.Abstraction;
using ConsoleFundies.Compliance;
using ConsoleFundies.Performance.Sorting;
using ConsoleFundies.Abstraction.DInjection.DIMethod;
using ConsoleFundies.Abstraction.DInjection.DIConstructor;
using ConsoleFundies.Abstraction.DInjection;
using ConsoleFundies.DataStructues;
using ConsoleFundies.DesignPatterns;
using ConsoleFundies.DesignPatterns.SOLID;

namespace ConsoleFundies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n---Program Started---\n\n");

            //LinkedList Example
            Console.WriteLine("\n\n---Linked List Example---\n\n");
            LinkedListExample llexample = new LinkedListExample();
            llexample.PrintLinkedListExamples();

            //Emnum Example
            Console.WriteLine("\n\n---Enum Example---\n\n");
            EnumExample enumExample = new EnumExample();
            enumExample.PrintSeasonInfo();

            // Exception Number Example
            Console.WriteLine("\n\n---Tuple Example---\n\n ");
            TupleExample tEx = new TupleExample();
            tEx.PrintTupleExamples();

            //Inheritance Example
            Console.WriteLine("\n\n---Inheritance Example---\n\n");

            // Create a myCar object
            Car myCar = new Car();
            // Call the honk() method (From the Vehicle class) on the myCar object
            myCar.honk();
            // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
            Console.WriteLine(myCar.brand + " " + myCar.modelName);

            //Interface Example
            Console.WriteLine("\n\n---Interface Example---\n\n ");
            Cat myCat = new Cat();
            myCat.animalSound();

            Dog myDog = new Dog();
            myDog.animalSound();


            // Basic Sorting
            Console.WriteLine("\n\n---C# Basic sorting---\n\n ");
            BasicSorting basicSort = new BasicSorting();
            basicSort.PrintSortedArray();

            // Constructor Dependency Injection
            Console.WriteLine("\n\n---Constructor Dependency Injection---\n\n ");
            CEmployeeBL cemployeeBL = new CEmployeeBL(new EmployeeDAL());
            cemployeeBL.PrintAllEmployees();

            // Method Dependency Injection
            Console.WriteLine("\n\n---Method Dependency Injection---\n\n ");
            MEmployeeBL memployeeBL = new MEmployeeBL();
            cemployeeBL.PrintAllEmployees();

            // Property Dependency Injection
            Console.WriteLine("\n\n---Property Dependency Injection---\n\n ");
            PEmployeeBL pemployeeBL = new PEmployeeBL();
            pemployeeBL.employeeDataObject = new EmployeeDAL();
            pemployeeBL.PrintAllEmployees();


            // Events example
            Console.WriteLine("\n\n---Events Example---\n\n ");
            ProcessBusinessLogic bl = new ProcessBusinessLogic();
            bl.ProcessCompleted += bl_ProcessCompleted; // register with an event
            bl.StartProcess();

            // Single Responsibility Principle
            Console.WriteLine("\n\n---Single Responsibility Principle---\n\n ");
            StudentRepository studRepo = new StudentRepository();
            var student = studRepo.FetchByID(1);
            Console.WriteLine(student.email);
            Console.WriteLine(studRepo.FetchByEmail("JoyBlum@School.com").StudentId);
            Console.WriteLine(studRepo.FetchByEmail("NotReal@School.com").StudentId);
            Console.WriteLine(studRepo.FetchByEmail("JoyBlum@School.com").StudentId);

            // Exception Number Example
            Console.WriteLine("\n\n---Exception Number Example---\n\n ");
            ExceptionHandling exTest = new ExceptionHandling();
            exTest.ExceptionNumberTest();


        }

        // event handler
        public static void bl_ProcessCompleted()
        {
            Console.WriteLine("Process Completed!");
        }
    }
}
