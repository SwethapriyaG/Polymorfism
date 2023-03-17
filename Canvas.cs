using System;
using System.Collections.Generic;
using System.Text;

namespace Ploymorfism
{
    class Canvas
    {
        public void DrawShapes(List<Shape> shapes) // Metod för rita former som acceptera listobjekt shapes
        {
            foreach( Shape shape in shapes) // loop för kalla Draw metod
            {
                shape.Draw();
            }
        }
    }
}
