https://leetcode.com/problems/reshape-the-matrix/description/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp81
{
    class Program
    {

        public static int[,] MatrixReshape(int[,] nums, int r, int c)
        {
            int len = nums.GetLength(0)*nums.GetLength(1);
            if (r * c > len) return nums;

            int[] arr = new int[len];
            int indice = 0;
            for(int i =0; i<nums.GetLength(0); i++)
            {
                for(int j =0; j<nums.GetLength(1); j++)
                {
                    arr[indice++] = nums[i, j];
                }
            }

            int[,] res = new int[r, c];
            indice = 0;
            for(int i =0; i<res.GetLength(0); i++)
            {
                for(int j =0; j<res.GetLength(1); j++)
                {
                    res[i, j] = arr[indice++];
                }
            }

            return res;
        }

        static void Main(string[] args)
        {

            int[,] matriz = {{1,2 }, { 3,4 } };
            int r = 1, c = 4;

            int[,] res = MatrixReshape(matriz, r, c);

            for(int i =0; i<res.GetLength(0); i++)
            {
                for(int j =0; j<res.GetLength(1); j++)
                {
                    Console.Write(res[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
