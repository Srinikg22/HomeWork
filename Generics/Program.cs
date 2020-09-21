using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Generic<int> gen = new Generic<int>();
            gen.Add(10);

            Generic<string> gen1 = new Generic<string>();
            gen1.Add("string");

            Generic<object> gen2 = new Generic<object>();
            gen2.Add(gen);

            Console.ReadLine();
        }
    }
}
