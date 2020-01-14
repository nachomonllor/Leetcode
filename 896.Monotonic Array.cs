https://leetcode.com/problems/monotonic-array/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static bool IsMonotonic(int[] A)
        {
            bool asciende = false;
            bool desciende = false;
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] > A[i - 1]) asciende = true;
                if (A[i] < A[i - 1]) desciende = true;

                if (asciende && desciende) return false;
            }

            return true;

        }

        static void Main(string[] args)
        {

            int[] input = { 1, 2, 2, 3 };
            //int[] input = { 6, 5, 4, 4 };
            //int[] input = { 1, 3, 2 };
            Console.WriteLine(IsMonotonic(input));



            Console.ReadLine();
        }
    }
}
