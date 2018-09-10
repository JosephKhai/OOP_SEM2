using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPChallenge
{
    public class Rectangle : Quadrilateral
    {
        public Rectangle(string Colour, float side1Length, 
            float side2Length) : base(side1Length, 
                side2Length, side1Length, side2Length, Colour)
        {

        }

        public virtual float GetArea()
        {
            float AreaRectangle = Side1Length * Side2Length;
            Console.WriteLine(AreaRectangle);

            return AreaRectangle;

        }
    
    }
}
