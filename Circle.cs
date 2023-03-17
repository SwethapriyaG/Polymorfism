using System;
using System.Collections.Generic;
using System.Text;

namespace Ploymorfism
{
    class Circle : Shape 
    {
        public override void Draw() //Subklassen override superklass metod
        {
            Console.WriteLine("Rita en cirkel!"); // Ny implementering
        }
    }
}
