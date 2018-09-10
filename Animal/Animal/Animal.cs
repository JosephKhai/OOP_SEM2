using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
   abstract class Animal
    {
        public string Life;
        public string Name;
        public string Hunger;

        public Animal (string life, string name, string hunger)
        {
            this.Life = life;
            this.Name = name;
            this.Hunger = hunger;
        }

    }
}
