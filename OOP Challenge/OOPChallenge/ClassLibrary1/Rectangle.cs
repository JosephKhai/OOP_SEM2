using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class Rectangle :Quadrilateral
    {
        public Rectangle(int side1Length, int side2Length, int side3Length, int side4Length, string Colour) : base(side1Length, side2Length, side3Length, side4Length, Colour)
        {

        }

        public virtual float GetArea()
        {
            float AreaRectangle = Side1Length * Side2Length;
            Console.WriteLine(AreaRectangle);

            return GetArea();

        }
    }
}
