using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Mamal : Animal
    {
        public int weight { get; set; }
        public string hair { get; set; }

        public Mamal(int weight, string hair, string Life, string Name, string Hunger) : base(Life, Name, Hunger)
        {
            this.weight = weight;
            this.hair = hair;
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
            Console.WriteLine("Eat Meat!!");
        }
    }
}
