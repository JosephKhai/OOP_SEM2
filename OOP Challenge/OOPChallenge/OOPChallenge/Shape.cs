using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPChallenge
{
    public abstract class Shape
    {
        public string Colour { get; set; }

        public Shape(string colour)
        {
            Colour = colour;
        }
    }
}
