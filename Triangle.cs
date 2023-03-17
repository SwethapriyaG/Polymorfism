using System;
using System.Collections.Generic;
using System.Text;

namespace Ploymorfism
{
    class Triangle : Shape
    {
        public override void Draw() // Subklassen override superklass metod
        {
            Console.WriteLine("Rita en triangel!"); // New implementation
        }
    }
}
