https://leetcode.com/problems/power-of-three/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        public static bool IsPowerOfThree(int n)
        {
            if (n <= 0) return false;
            if (n == 1) return true;
 
            while (n > 0)
            {
                if (n % 3 == 0)
                {
                    n /= 3;
                    if (n == 1)
                    {
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IsPowerOfThree(27));
            Console.ReadLine();

        }
    }
}
