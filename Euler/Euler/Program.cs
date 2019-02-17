using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question2:\nThe sum of all even fibonacci numbers which are less than 4000000 is: " + Q2(4000000)); // Question 2: Scott Burnett
        }

        static int Q2(int arg)// Question 2: Scott Burnett
        {
            int max = 0,
                n = 0;
              for (int i = fib(n); i < arg; i = fib(++n))
                if (i % 2 == 0)
                    max += i;
              
            return max;
        }//Question 2

        static int fib(int arg)// Fibonacci: Scott Burnett
        {
            if (arg < 2)
                return 1;
            else
                return (fib(arg - 2) + fib(arg - 1));
        }
    }
}
