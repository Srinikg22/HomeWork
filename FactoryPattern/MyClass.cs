using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class MyClass : IFactory
    {
        public void DoSomeTask()
        {
            Console.WriteLine("MyClass");
        }
    }

    public class MyClass2 : IFactory
    {
        public void DoSomeTask()
        {
            Console.WriteLine("MyClass2");
        }
    }

    class Factory
    {
        public IFactory ObjectCreation(int option)
        {
            switch(option)
            {
                case 1:
                    return new MyClass();
                case 2:
                    return new MyClass2();
                default:
                    return new MyClass2();
            }
        }
    }
}
