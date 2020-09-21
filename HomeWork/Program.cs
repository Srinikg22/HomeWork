using System;

namespace HomeWork
{
    public class Program
    {
        public void DisplayOutVariable(out int i)
        {
            i = 10;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int i = 50;
            p.DisplayOutVariable(out i);
            Console.WriteLine("Out Parameter" + i);
        }
    }
}
