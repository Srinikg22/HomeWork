using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class TransitiveExample
    {
        private int value = 10;
        public static int a = 20;

        // Static Constructor does not require access modifiers
        // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/static-constructors
        static TransitiveExample()
        {
            a = 20;
        }

        ~TransitiveExample()
        {
            // Destructor
        }

        public void DisplayText()
        {
            Console.WriteLine("Transitive Class");
        }

        public class B : TransitiveExample
        {
            public int GetValue()
            {
                Console.WriteLine(a);
                return a;
            }
        }
    }

    public class C : TransitiveExample
    {
        public int GetValue()
        {
            Console.WriteLine(a);
            return a;
        }

        public void DisplayText()
        {
            Console.WriteLine("C Class");
        }
    }
}
