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
            Console.WriteLine(Q5(20) + " is the smallest number divisable by 1 to 20");
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
    }
}
