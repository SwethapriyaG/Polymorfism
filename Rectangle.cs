using System;
using System.Collections.Generic;
using System.Text;

namespace Ploymorfism
{
    class Rectangle : Shape   // ärver basklassen
    {
        public override void Draw () // Subklassen override superklass metod
        {
            Console.WriteLine("Rita en rektangel!");
        }
    }
}
