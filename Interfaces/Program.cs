using System;
using System.Collections;
using System.Collections.Generic;

namespace Interfaces
{
    // Class can't be declared as private, protected, private protected, internal protected.
    // Hetrogenious - Different Type - Related to Generics 
    // Homogenious - Same Type 
    class Program : ISample
    {
        void ISample.Display()
        {
            Console.WriteLine("ISample");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Display<Program> : List<Program>
    {
        
    }
}
