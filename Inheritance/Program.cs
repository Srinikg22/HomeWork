using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var b = new TransitiveExample.B();
            Console.WriteLine(b.GetValue());

            var c = new C();
            Console.WriteLine(c.GetValue());
            c.DisplayText();
        }


        // The example displays the following output:
        //       10
    }
}
