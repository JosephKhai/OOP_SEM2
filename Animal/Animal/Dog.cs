using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Dog : Mamal
    {
        public int leg { get; set; }

        public Dog(int leg, int weight, string hair, string Life, string Name, string Hunger) : base(weight, hair,Life, Name, Hunger)
        {
            this.leg = leg;
            this.weight = weight;
            this.hair = hair;
            this.Life = Life;
            this.Name = Name;
            this.Hunger = Hunger;
        }
    }
}
