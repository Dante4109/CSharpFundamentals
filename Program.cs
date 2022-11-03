using System;
using System.Collections.Generic;
using ConsoleFundies.Abstraction;
using ConsoleFundies.Random;
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
            myCat.AnimalSound();

            Dog myDog = new Dog();
            myDog.AnimalSound();

            var watch = new System.Diagnostics.Stopwatch();

            watch.Start();

            // Chess Board
            Console.WriteLine("\n\n---C# Chess Board example---\n\n ");
            var grid = ChessBoard.CreateGrid(4, 9, 'B', 'W'); // returns string array
            PrintStringArray(grid);


            // Array.Sort
            Console.WriteLine("\n\n---C# Array.Sort---\n\n ");
            BasicSorting basicSort = new BasicSorting();
            basicSort.PrintSortedArray();

            watch.Stop();

            Console.WriteLine($"\n Execution Time: {watch.ElapsedMilliseconds} ms");

            // Insertion Sort
            Console.WriteLine("\n\n---C# Insertion Sort---\n\n ");
            int[] arr = { 73, 57, 49, 99, 133, 20, 1 };
            var insertionSort = new InsertionSort();
            watch.Start();
            var insertionSortedArray = insertionSort.Sort(arr);
            watch.Stop();
            PrintIntArray(insertionSortedArray);
            Console.WriteLine($"\n Execution Time: {watch.ElapsedMilliseconds} ms");

            // Quick Sort
            Console.WriteLine("\n\n---C# Quick Sort---\n\n ");
            var array = new int[] { 73, 57, 49, 99, 133, 20, 1 };
            var sortFunction = new QuickSort();
            watch.Start();
            var quickSortedArray = sortFunction.SortArray(array, 0, array.Length - 1);
            watch.Stop();
            PrintIntArray(quickSortedArray);            
            Console.WriteLine($"\n Execution Time: {watch.ElapsedMilliseconds} ms");

            // IComparable Sorting
            Console.WriteLine("\n\n---IComparable Sorting---\n\n ");
            CompareTemperatures.PrintTemperatures(); 

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


            // Liskov Substituion Principle
            Console.WriteLine("\n\n---Liskov Substituion Principle---\n\n ");
            Rectangle sqr1 = new Square();
            sqr1.Height = 6;
            sqr1.Width = 8;

            Console.WriteLine(AreaCalculator.CalculateArea(sqr1)); //returns 64

            Rectangle sqr2 = new Square();
            sqr2.Height = 8;
            sqr2.Width = 6;

            Console.WriteLine(AreaCalculator.CalculateArea(sqr2)); //returns 36


            // Exception Number Example
            Console.WriteLine("\n\n---Exception Number Example---\n\n ");
            ExceptionHandling exTest = new ExceptionHandling();
            exTest.ExceptionNumberTest();


        }

        // event handler
        private static void bl_ProcessCompleted()
        {
            Console.WriteLine("Process Completed!");
        }


        // helper methods
        private static void PrintIntArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");

            Console.Write("\n");
        }
        private static void PrintStringArray(string[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");

            Console.Write("\n");
        }
    }
}
