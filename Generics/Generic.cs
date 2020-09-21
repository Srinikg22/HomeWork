using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Generic<T>
    {
        public void Add(T input)
        {
            Console.WriteLine(input.GetType());
        }
    }
}
