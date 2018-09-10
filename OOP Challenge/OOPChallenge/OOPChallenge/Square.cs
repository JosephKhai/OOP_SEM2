using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPChallenge
{
    public class Square : Quadrilateral
    {
       public Square (string Colour, float side1Length) : base(side1Length,
           side1Length, side1Length, side1Length, Colour)
        {

        }

        public virtual float GetArea()
        {
            float AreaSquare = Side1Length * Side1Length;
            Console.WriteLine(AreaSquare);

            return AreaSquare;

        }

    
    }
}
