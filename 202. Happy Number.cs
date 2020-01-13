https://leetcode.com/problems/happy-number/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static int SumCuadDig(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                sum += (n % 10) * (n % 10);
                n /= 10;
            }
            return sum;
        }

        public static bool IsHappy(int n)
        {
            HashSet<int> hs = new HashSet<int>();
            while(n != 1 )
            {
                bool agrego = hs.Add(n);
                if (!agrego) return false;
                n = SumCuadDig(n);
            }
            return true;
        }

        static void Main(string[] args)
        {

            Console.WriteLine(  IsHappy(488));

            Console.ReadLine();
        }
    }
}
