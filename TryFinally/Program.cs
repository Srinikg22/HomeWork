﻿using System;

namespace TryFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // TryCast produces an unhandled exception.
                TryCast();
            }
            catch (Exception ex)
            {
                // Catch the exception that is unhandled in TryCast.
                Console.WriteLine
                    ("Catching the {0} exception triggers the finally block.",
                    ex.GetType());

                // Restore the original unhandled exception. You might not
                // know what exception to expect, or how to handle it, so pass
                // it on.
                throw;
            }
        }

        public static void TryCast()
        {
            int i = 123;
            string s = "Some string";
            object obj = s;

            try
            {
                // Invalid conversion; obj contains a string, not a numeric type.
                i = 124;

                // The following statement is not run.
                Console.WriteLine("WriteLine at the end of the try block.");
            }
            finally
            {
                // Report that the finally block is run, and show that the value of
                // i has not been changed.
                Console.WriteLine("\nIn the finally block in TryCast, i = {0}.\n", i);
            }
        }
    }
}
