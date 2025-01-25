using System;
using System.Collections;
using System.ComponentModel;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using C43_G05_ADV01.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C43_G05_ADV01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // understand generics in C# by comparing non-generic methods using overloads with the generic approach


            // First, I need to recall what method overloading is. Overloading allows multiple methods
            // with the same name but different parameters. So, if you want to handle different data types without generics, you'd create separate methods for each type.
            // For instance, a Swap method for int and string would have two overloads. 

            // Usage
            Swapper swapper = new Swapper();
            //int x = 1, y = 2;
            //string s1 = "Hello", s2 = "World";

            //swapper.Swap(ref x, ref y);      // Uses integer overload
            //swapper.Swap(ref s1, ref s2);    // Uses string overload


            // Then, the generic method. Generics let you write a single method that works with any data type.
            // The Swap method would use a type parameter T,
            // making it more flexible and reducing code duplication.

            // Usage
            GenericSwapper genericSwapper = new GenericSwapper();
            int x = 1, y = 2;
            string s1 = "Hello", s2 = "World";

            genericSwapper.Swap(ref x, ref y);     // Works with integers
            genericSwapper.Swap(ref s1, ref s2);   // Works with strings


            // explain the differences.Points to cover: code duplication in non - generic vs DRY in generic,
            // type safety(generics are safe, overloads might need checks),
            // maintainability(adding new types in non - generic requires new methods),
            // performance(generics avoid boxing), and flexibility(generics work with any type).


            // Example : Non - Generic vs Generic Collections

            // Using ArrayList (non-generic collection)
            ArrayList list = new ArrayList();
            //list.Add(10);       // Integer
            //list.Add("Apple");  // String (mixed types allowed)
            //int num = (int)list[0];  // Requires explicit casting

            // Using List<T> (generic collection)
            List<int> numbers = new List<int>();
            numbers.Add(10);
             //numbers.Add("Apple"); // Compile-time error (type safety)
            int num = numbers[0];    // No casting needed

            // Key Differences

            //# Non - Generic(Overloading)                          # Generic

            //  Requires multiple method definitions.                 Single method works for all types.
            //  Code duplication(violates DRY principle).             Reusable and clean code.
            //  Limited to predefined types(e.g., int, string).       Works with any type(even custom classes).
            //  Runtime errors possible(e.g., invalid casting).       Compile - time type safety.
            //  Less maintainable(add new types = new methods).       Easily extendable.
            //  Example: Swap(ref int a, ref int b)                   Example: Swap<T>(ref T a, ref T b)


            //Why Use Generics?


            //Type Safety: Avoid runtime errors with compile - time checks.

            //Reusability: Write code once, use it for any type.

            //Performance: Avoids boxing / unboxing for value types.

            //Clean Code: Eliminates redundant method overloads.
        }
    }
}
