using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPChallenge
{
    public class RightAngleTriangle : Triangle
    {
        public RightAngleTriangle (String colour, float side1Length, float side2Length) : base(colour, side1Length, side2Length, side1Length)
        {

        }

        public virtual float GetArea()
        {
            float AreaRightTriangle =  0.5f * side1Length * side2Length;
            Console.WriteLine(AreaRightTriangle);

            return AreaRightTriangle;
        }
    }
}
