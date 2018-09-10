using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Reptile : Animal
    {
        public string eyeColor { get; set; }
        public int bodySize { get; set; }

        public Reptile(string eyeColor, int bodySize, string Life, string Name, string Hunger) : base( Life, Name, Hunger)
        {
            this.eyeColor = eyeColor;
            this.bodySize = bodySize;
            this.Life = Life;
            this.Name = Name;
            this.Hunger = Hunger;
        }

        public void Move()
        {
            Console.WriteLine("Chhoooooo!!!");
        }

        public void Feed()
        {
            Console.WriteLine("Eat Grass!!");
        }


    }
}
