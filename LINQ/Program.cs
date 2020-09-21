using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program : Linq
    {
        //static void Main(string[] args)
        //{
        //    Linq lq = new Linq();
        //    IEnumerable<int> score =  lq.Display();

        //    foreach(int scores in score)
        //    {
        //        Console.WriteLine(score);   
        //    }

        //    Console.ReadLine();
        //}
        static void Main()
        {

            // Specify the data source.
            int[] scores = new int[] { 97, 92, 81, 60 };

            // Define the query expression.
            IEnumerable<int> scoreQuery =
                from score in scores
                where score > 80
                select score;

            // Execute the query.
            foreach (int i in scoreQuery)
            {
                Console.Write(i + " ");
            }
        }
    }
}
