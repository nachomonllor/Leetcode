using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1572_Matrix_Diagonal_Sum
{
    class Program
    {

        public static int DiagonalSum(int[][] mat)
        {
            //int mid = l + (r - l) / 2;
            int a = 0;

            int n = mat.Length;

            for (int i = 0; i < mat.Length; i++)
            {
                a += mat[i][i];
                a += mat[i][mat.Length - 1 - i];
            }

            return (n%2 != 0) ? a - mat[n / 2][n / 2] : a;  

        }


        static void Main(string[] args)
        {

            //int[][] mat = { new int[] { 1, 2, 3},
            //                new int[] { 4, 5, 6},
            //                new int[] { 7, 8, 9}
            //};

            ////Output: 25
            ////Explanation: Diagonals sum: 1 + 5 + 9 + 3 + 7 = 25
            //Console.WriteLine(DiagonalSum(mat));


            int[][] mat ={
                          new int[] {1, 1, 1, 1},
                          new int[] {1, 1, 1, 1},
                          new int[] {1, 1, 1, 1},
                          new int[] {1, 1, 1, 1}};
            //Output: 8


            Console.WriteLine(DiagonalSum(mat));


            Console.ReadLine();
        }
    }
}
