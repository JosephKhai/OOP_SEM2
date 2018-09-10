using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPChallenge
{
    public class Triangle : Shape
    {
       public float side1Length { get; set; }
       public float side2Length { get; set; }
       public float side3Length { get; set; }

        public Triangle(String Colour, float side1Length, float side2Length, float side3Length): base (Colour)
        {
            this.side1Length = side1Length;
            this.side2Length = side2Length;
            this.side3Length = side3Length;
        }

        public float GetPerimeter()
        {
            float Perimeter = (side1Length * side1Length) + (side2Length * side2Length);
            Console.WriteLine(Perimeter);

            return Perimeter;
        }

        

    }
}
