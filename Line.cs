using System;
using System.Collections.Generic;
using System.Text;

namespace Ploymorfism
{
    class Line : Shape
    {
        public override void Draw() // Subklassen override superklass metod
        {
            Console.WriteLine("Rita ett streck!"); // New implementation
        }
    }
}
