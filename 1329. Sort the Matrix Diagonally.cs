//https://leetcode.com/problems/sort-the-matrix-diagonally/
using System;
using System.Collections.Generic;
using System.Linq;
 
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

       

        public static int[][] DiagonalSort(int[][] mat)
        {
            int n = mat[0].Length;

            int col_inicio = n - 1;
            for (int j = col_inicio; j >= 0; j--)
            {
                
                int f = 0;
                int c = j;

                int[] cont = new int[101];

                while (f < mat.Length && c < mat[0].Length)
                {
                    cont[mat[f][c]]++;
                    f++;
                    c++;
                }
            

                f = 0;
                c = j;

                while (f < mat.Length && c < mat[0].Length)
                {
                    for (int num = 0; num <= 100; num++)
                    {
                        for (int veces = 0; veces < cont[num]; veces++)
                        {
                            mat[f][c] = num;
                            f++;
                            c++;
                        }
                    }
                }
            }

        

            for (int fila = 1; fila < mat.Length; fila++)
            {
                int f = fila;
                int c = 0;

                int[] cont = new int[101];
                while (f < mat.Length && c < mat[0].Length)
                {
                    
                    cont[mat[f][c]]++;
                    f++;
                    c++;
                }

            
                f = fila;
                c = 0;
    
                while (f < mat.Length && c < mat[0].Length)
                {
                    for (int num = 0; num <= 100; num++)
                    {
                        for (int veces = 0; veces < cont[num]; veces++)
                        {
                            mat[f][c] = num;
                            f++;
                            c++;
                        }
                    }
                }

            }


            return mat;

        }


        static void Main(string[] args)
        {

            int[][] mat = { 
                          new int[] { 3, 3, 1, 1 }, 
                          new int[] { 2, 2, 1, 2 }, 
                          new int[] { 1, 1, 1, 2 } };


            int[][] res = DiagonalSort(mat);

            for (int i = 0; i < res.Length; i++)
            {
                for (int j = 0; j < res[i].Length; j++)
                {
                    Console.Write(res[i][j] + " ");
                }
                Console.WriteLine();
            }


            Console.ReadLine();


        }
    }
}
