https://leetcode.com/problems/transpose-matrix/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        public static int[][] Transpose(int[][] A)
        {

            List<List<int>> res = new List<List<int>>();

            for (int col = 0; col < A[0].Length; col++)
            {
                res.Add(new List<int>());
                for (int fila = 0;  fila < A.Length; fila++)
                {
                    res[col] .Add(A[fila][col]);
                    
                }

            }

            int[][] ans = new int[res.Count][];

            for(int i =0; i<res.Count; i++)
            {
                ans[i] = new int[res[0].Count];
                for(int j =0; j<res[i].Count; j++)
                {
                    ans[i][j] = res[i][j];
                }
            }

            return ans;
        }



        static void Main(string[] args)
        {
            //int[][] Input =  {
            //    new int[] { 1, 2, 3 },
            //    new int[] {4,5,6 },
            //    new int[] {7,8,9 } };
            int[][] Input = { new int[] { 1, 2, 3 },
                              new int[] { 4, 5, 6 } };

            int[][] t = Transpose(Input);


            for(int i =0; i<t.Length; i++)
            {
                for(int j =0; j<t[i].Length; j++)
                {
                    Console.Write(t[i][j] + " ");
                }
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}
