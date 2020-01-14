https://leetcode.com/problems/flipping-an-image/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {


        public static int[][] FlipAndInvertImage(int[][] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                int j = 0, k = A[i].Length - 1;
                while (j < k)
                {
                    int temp = A[i][j];
                    A[i][j] = A[i][k];
                    A[i][k] = temp;
                    j++;
                    k--;
                }
                for (int j = 0; j < A[i].Length; j++)
                {
                    if (A[i][j] == 0)
                    {
                        A[i][j] = 1;
                    }
                    else
                    {
                        A[i][j] = 0;
                    }
                }
            }

         


          
            return A;
        }


        static void Main(string[] args)
        {
            //[[1,1,0],
            // [1,0,1],
            // [0,0,0]]


            int[][] m = { new int[] { 1, 1, 0 },
                new int[]{1,0,1 },
                new int[]{0,0,0 } };

            int[][] flip = FlipAndInvertImage(m);

            for(int i =0; i<flip.Length; i++)
            {
                for(int j =0; j<flip[i].Length; j++)
                {
                    Console.Write(flip[i][j] + " ");
                }
                Console.WriteLine();
            }



            Console.ReadLine();
        }
    }
}
