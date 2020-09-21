using System;

namespace FactoryPattern
{
    class Program : Factory
    {
        static void Main(string[] args)
        {
            Factory fact = new Factory();
            IFactory fac = fact.ObjectCreation(1);
            fac.DoSomeTask();

            IFactory fac1 = fact.ObjectCreation(2);
            fac1.DoSomeTask();

            Console.ReadLine();
        }
    }
}
