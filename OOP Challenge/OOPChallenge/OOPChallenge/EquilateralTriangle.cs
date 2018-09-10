using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPChallenge
{
    public class EquilateralTriangle : Triangle
    {
        public EquilateralTriangle(String colour, float side1Length) : base(colour, side1Length, side1Length, side1Length)
        {

        }

        public virtual float GetArea()
        {
            float AreaEquilateralTriangle = 0.433012702f * side1Length * side1Length;
            Console.WriteLine(AreaEquilateralTriangle);

            return AreaEquilateralTriangle;
        }
    }
}
