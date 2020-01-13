https://leetcode.com/problems/power-of-three/description/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp115
{
    class Program
    {

     
        public static  bool IsPowerOfThree(int n)
        {
            if (n <= 0) return false;
           // Console.WriteLine(Math.Pow(3, Math.Ceiling(Math.Log(n, 3))));
            return Math.Floor( Math.Pow(3, Math.Ceiling( Math.Log(n,3)))) == n;
        }


        static void Main(string[] args)
        {
            //return Math.Pow(2.0, Math.Log(n, 2.0)) == n;
            // int n = 536870912;
            int n = 243;
            //Console.WriteLine(Math.Floor(Math.Log(n, 3)));
            //Console.WriteLine(Math.Pow(  2, Math.Log(n, 2)));
            Console.WriteLine(IsPowerOfThree(n));
         
            Console.ReadLine();
        }
    }
}
