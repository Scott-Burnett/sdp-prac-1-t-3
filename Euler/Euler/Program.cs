﻿using System;
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
            Console.WriteLine("Question 7: " + Q7());
            Console.ReadLine();
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
    }
}
