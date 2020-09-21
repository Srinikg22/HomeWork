using System;
using System.Collections.Generic;

namespace Arrrays
{
    class Program : Calling
    {
        static void Main(string[] args)
        {
            //Array Declaration

            int[] singleDimentional = new int[5];
            string[] strArray = new string[10];
            int[][] multiDemantionalArr = new int[6][];
            decimal[] decArray = new decimal[10];

            //Array Initialization

            //int[] array1 = new int[] { 1,2,3,4,5};
            
            Console.WriteLine("Hello World!");

            Calling c = new Calling();
            //Console.WriteLine(c.Name);
            //Console.WriteLine(c.Id);
        }
    }
}
