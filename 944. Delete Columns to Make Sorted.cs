https://leetcode.com/problems/delete-columns-to-make-sorted/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        public static int MinDeletionSize(string[] A)
        {

            int n = A[0].Length;
            int cont = 0;

            for (int j = 0; j < n; j++)
            {
                int i;
                for (i = 1; i < A.Length; i++)
                {
                    if (A[i-1][j] > A[i][j])
                    {
                        break;
                    }
                }
                if (i < A.Length)
                {
                    cont++;
                }
            }

            return cont;
        }


        static void Main(string[] args)
        {
            //string[] input = { "zyx", "wvu", "tsr" };
            string[] input = { "cba", "daf", "ghi" };
            Console.WriteLine(MinDeletionSize(input));


            Console.ReadLine();
        }
    }
}

