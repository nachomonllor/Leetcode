https://leetcode.com/problems/perfect-number/description/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp73
{
    class Program
    {
        //public static bool CheckPerfectNumber(int num)
        //{
        //    int sum = 0;
        //    for (int i = 1; i <= num / 2; i++)
        //        if (num % i == 0) sum += i;

        //    return sum == num;
        //}

        public static bool CheckPerfectNumber(int num)
        {
            if (num < 2) return false;
            int sum = 0;
            // Note that this loop runs till square root
            for (int i = 1; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    // If divisors are equal, print only one
                    if (num / i == i)
                    {
                        sum += i;
                    }
                    else
                    { // Otherwise print both
                        
                        sum += i;
                        if ((num / i) != num)
                        {
                            sum += (num / i);
                        }

                    }
                }
            }


            return sum == num;
        }

        

        static void Main(string[] args)
        {
            for (int i = 1; i <= 1000000; i++)
            {
                if (CheckPerfectNumber(i))
                {
                    //Console.WriteLine();
                    Console.Write(i + " ");
                }
            }
            //  Console.WriteLine(CheckPerfectNumber(99999995));
            // Console.WriteLine(CheckPerfectNumber(28));


            Console.ReadLine();
        }
    }
}
