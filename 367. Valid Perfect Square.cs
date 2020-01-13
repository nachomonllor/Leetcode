https://leetcode.com/problems/valid-perfect-square/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        public bool IsPerfectSquare(int num)
        {
            for (int i = 1; i * i <= num; i++)
            {
                if (i * i == num) return true;
                else if (i * i > num || i * i < 0) return false;
            }
            return false;
        }

        static void Main(string[] args)
        {

            Console.ReadLine();
        }
    }
}

