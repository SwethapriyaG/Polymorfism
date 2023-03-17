using System;
using System.Collections.Generic;

namespace Ploymorfism
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>(); // Declerar list objekt
            shapes.Add(new Circle()); // lägga till objekt i listobjektet instansiera olika barn av basklassformen och lägga till objektformen i listan
            shapes.Add(new Rectangle());
            shapes.Add(new Triangle());
            shapes.Add(new Line());

            var canvas = new Canvas(); 
            canvas.DrawShapes(shapes); //kallar metoden att rita formerna

        }
    }

}
