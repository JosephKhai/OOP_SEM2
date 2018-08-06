using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static int Fibonacci(int num1, int num2, int numFibs)
        {
            if (numFibs > 0)
            {
                numFibs--;
                num2 = num1 + num2;
                return Fibonacci(num2, num2 + num1, numFibs);
            }
            return num2 + num1;
        }

        static int Factorial(int input, int ans)
        {
            if (input == 0)
            {
                return ans;
            }

            ans = ans * input;
            return Factorial(input - 1, ans);
        }

        bool FibCheck(int num)
        {
            int ans = 0;
            int a = 1, b = 1;
            
            while (ans < num)
            {
                ans = a + b;
                if (ans == num)
                {
                    return true;
                }

                a = b;
                b = ans;
            }

            return false;

        }


        bool PrimeCheck(int num, int divisor)
        {
            if (num == divisor)
            {
                return true;
            }

            if (num > divisor)
            {
                return num % divisor != 0 && PrimeCheck(num, divisor + 1);
            }
            return false;
        }


        
    }

    
}
