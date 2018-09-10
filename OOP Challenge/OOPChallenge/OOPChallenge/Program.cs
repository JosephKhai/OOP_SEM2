using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOPChallenge
{
    class Program
    {

        public static int Side1Length { get; private set; }
        public static int Side2Length { get; private set; }

        static void Main(string[] args)
        {


            bool Menu = true;
            while (Menu == true)
            {
                try
                {

                    Console.WriteLine("Welcome!, Please Enter number to select from menu");
                    Console.WriteLine("");
                    Console.WriteLine("1. Area of a Square");
                    Console.WriteLine("2. Area of a Rectangle");
                    Console.WriteLine("3. Exit the Programme");
                    Console.WriteLine("");
                    string Select = Console.ReadLine();

                    if (Select == "1")
                    {

                        Console.WriteLine("Enter the color");
                        string color = Console.ReadLine();
                        Console.WriteLine("Enter the length");
                        float Side1Length = float.Parse(Console.ReadLine());
                        Square square = new Square(color, Side1Length);

                        if (Side1Length <= 0)
                        {
                            throw new LessThanOneexception();
                            
                        }
                        Console.WriteLine(square.GetArea());
                       




                    }
                    else if (Select == "2")
                    {
                        Console.WriteLine("Enter the color");
                        string color = Console.ReadLine();
                        Console.WriteLine("Enter the length");
                        float Side1Length = float.Parse(Console.ReadLine());
                        if (Side1Length <= 0)
                        {
                            throw new LessThanOneexception();
                        }
                      
       
                        Console.WriteLine("Enter the Width");
                        float Side2Length = float.Parse(Console.ReadLine());
                        Rectangle rectangle = new Rectangle(color, Side1Length, Side2Length);


                        if (Side2Length <= 0)
                        {
                            throw new LessThanOneexception();
                        }
                        Console.WriteLine(rectangle.GetArea());


                    }
                    

                    else if (Select == "3")
                    {
                        break;
                    }

                    else
                    {
                        //something, exit??
                        Console.WriteLine("You've selected something invalid");
                        //Menu = false;
                    }
                }

                catch (LessThanOneexception zero)
                {
                    Console.WriteLine(zero.Message);

                }

                catch (FormatException e)
                {

                    Console.WriteLine(e.Message);


                }
            }
            //return Menu;
            Console.WriteLine("Exiting Program!....Please press Enter to exit!");
           Console.ReadLine();
        }


    }


    public class LessThanOneexception : Exception
    {
        public LessThanOneexception() : base("number must not be less than 1")
        {

        }
    }

   

}
