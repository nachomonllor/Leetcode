https://leetcode.com/problems/power-of-two/description/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp115
{
    class Program
    {

        public static bool IsPowerOfTwo(int n)
        {
            if (n <= 0) return false;
            // return Math.Pow( Math.Log(n, 2), 2)==n;
            //Console.WriteLine(Math.Pow(2, (int) Math.Log(n, 2)));
            return Math.Floor( Math.Pow(2, Math.Floor( Math.Log(n, 2)))) == n;
        }

        static void Main(string[] args)
        {
            //return Math.Pow(2.0, Math.Log(n, 2.0)) == n;
            // int n = 536870912;
            int n = 3;
            //Console.WriteLine(Math.Pow(  2, Math.Log(n, 2)));

            //Console.WriteLine(Math.Log(n, 2));
            //Console.WriteLine(Math.Log(n, 2));
            Console.WriteLine(IsPowerOfTwo(n) );
         
            Console.ReadLine();
        }
    }
}

