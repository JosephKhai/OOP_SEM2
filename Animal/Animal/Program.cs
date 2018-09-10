using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Reptile reptile = new Reptile("Blue", 14, "Wild Life", "George", "nutrition");
            Dog dog = new Dog(4, 45, "Gray", "Wild LIfe", "Coco", "nutrition");


            Console.WriteLine("Reptile has " + reptile.eyeColor + " eye color");
            Console.WriteLine("Reptile body size is " + reptile.bodySize);
            Console.WriteLine("Reptile is " + reptile.Life + " style");
            Console.WriteLine("Reptile name is " + reptile.Name);
            Console.WriteLine("Reptile feed " + reptile.Hunger);
            reptile.Move();
            reptile.Feed();

            Console.ReadLine();



            Console.WriteLine("Dog has " + dog.leg + " leg");
            Console.WriteLine("Dog weight is " + dog.weight + " kg");
            Console.WriteLine("Dog Hair is " + dog.hair);
            Console.WriteLine("Dog is " + dog.Life + " style");
            Console.WriteLine("Dog name is " + dog.Name);
            Console.WriteLine("Mamal feed " + dog.Hunger);
            dog.Move();
            dog.Feed();

            Console.ReadLine();

        }



        
    }
}
