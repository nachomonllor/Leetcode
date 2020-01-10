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
            while (n > 1 && n % 3 ==0)
            {
                n /= 3;
            }

            if (n == 1) return true;
            return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IsPowerOfThree(9));

            Console.ReadLine();
        }
    }
}
