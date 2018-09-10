using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class Square : Quadrilateral
    {
       public Square (int side1Length, int side2Length, int side3Length, int side4Length, string Colour): base(side1Length, side2Length, side3Length, side4Length, Colour)
        {

        }

        public virtual float GetArea()
        {
            float AreaSquare = Side1Length * Side1Length;
            Console.WriteLine(AreaSquare);

            return GetArea();

        }


    }
}
