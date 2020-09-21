using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Performing base class drawing tasks");
        }
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Circle");
            base.Draw();
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Rectangle");
            base.Draw();
        }
    }
    public class Triangle : Shape
    {
        public sealed override void Draw()
        {
            Console.WriteLine("Triangle");
            base.Draw();
        }
    }

    public class SemiCircle : Shape
    {
        public new void Draw()
        {
            Console.WriteLine("SemiCircle");
        }
    }

    public class Sample
    {

    }
}

