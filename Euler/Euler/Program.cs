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

            Console.WriteLine("Question 5: " + Q5(20) + " is the smallest number divisable by 1 to 20"); // Question5: William Stapleton

            Console.WriteLine("Question 7: " + Q7());// Question 7: Gibson Muriithi

            Console.ReadLine();
        }

        static int Q5(int num) //Question 5 by FreeWillie03
        {
            int small = 1;
            
                for (int i = num; i > 0; i--)
                {
                    if(small % i != 0)
                    {
                        small++; i = num;
                    }
                    
                }     
            return small;    
        }
        static long Q7()  // Gibson Euler Question 7 
        {
            int count = 0;
            int num = 2;
            while (true)
            {
                if (isPrime(num)) count++;
                if (count == 10001) break;
                num++;
            }
            return num;
        }

        static bool isPrime(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0) return false;
            }
            return true; 
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
