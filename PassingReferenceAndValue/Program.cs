using System;

namespace PassingReferenceAndValue
{
    class Program : CallByValue, CallByReference
    {

        void CallByValue.ChangeValue(int[] pArray)
        {
            pArray[0] = 888;  // This change affects the original element.
            pArray = new int[5] { -3, -1, -2, -3, -4 };   // This change is local.
            System.Console.WriteLine("Inside the method, the first element is: {0}", pArray[0]);
        }

        void CallByReference.ChangeReference(ref int[] pArray)
        {
            // Both of the following changes will affect the original variables:
            pArray[0] = 888;
            pArray = new int[5] { -3, -1, -2, -3, -4 };
            System.Console.WriteLine("Inside the method, the first element is: {0}", pArray[0]);
        }

        static void Main(string[] args)
        {
            CallByValue p = new Program();
            CallByReference reff = new Program();

            int[] arr = { 1, 4, 5 };
            System.Console.WriteLine("Inside Main, before calling the method, the first element is: {0}", arr[0]);

            p.ChangeValue(arr);

            System.Console.WriteLine("Inside Main, after calling the method, the first element is: {0}", arr[0]);
            Console.ReadLine();

            int[] arrReference = { 1, 4, 5 };
            System.Console.WriteLine("Inside Main, before calling the method, the first element is: {0}", arr[0]);

            reff.ChangeReference(ref arr);
            System.Console.WriteLine("Inside Main, after calling the method, the first element is: {0}", arr[0]);
        }
    }
}
