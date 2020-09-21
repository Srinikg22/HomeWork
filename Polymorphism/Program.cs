using System;
using System.Collections.Generic;

namespace Polymorphism
{
    class Program
    {

        // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/polymorphism
        static void Main(string[] args)
        {
            var shapes = new List<Shape>
            {
                new Circle(),
                new Rectangle(),
                new Triangle(),
               // new SemiCircle(), Error because its doesn't inherit shape class 
               // new Sample()
            };

            //foreach (var shape in shapes)
            //{
            //    shape.Draw();
            //}

            //Circle s1 = new Circle();
            //s1.Draw();

            //Shape s2 = (Shape)s1;
            //s2.Draw();

            //SemiCircle sc = new SemiCircle();

            //Shape s3 = (SemiCircle)sc;
            //sc.Draw();

            //Triangle t = new Triangle();
            //t.Draw();

            SemiCircle sc = new SemiCircle();
            ((Shape)sc).Draw();
        }
    }
}
