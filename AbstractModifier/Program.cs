using System;

namespace AbstractModifier
{
    abstract class Program
    {
        public abstract int GetArea();

        public abstract int GetCode();

        public abstract int a
        {
            get; set;
        }

        public void Display()
        {

        }
    }

    abstract class ImplementAbstract : Program
    {
        int side = 10;
        public override int GetArea() => side * side;

        public override int GetCode() => side * side;

        public override int a
        {
            get
            {
                return 1;
            }
            set
            {
                a = 10;
            }
        }
    }

    class Pro : ImplementAbstract
    {
        int side = 20;
        public override int GetArea() => side * side;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Pro ia = new Pro();
            Console.WriteLine(ia.a);
        }
    }
}
