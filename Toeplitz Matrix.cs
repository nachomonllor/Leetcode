https://leetcode.com/problems/toeplitz-matrix/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {


        public static bool IsToeplitzMatrix(int[,] matrix)
        {
            int filas = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int col = 0; col < cols; col++)
            {
                int c = col;
                int pre = matrix[0, c];
                for (int fila = 0; c < cols && fila < filas ; fila++)
                {
                    // Console.Write(matrix[fila, c++] + " ");
                    if (pre != matrix[fila, c++]) return false;
                }
                //Console.WriteLine();
            }

            for(int fila = 1; fila< filas; fila ++)
            {
                int f = fila;
                int pre = matrix[f, 0];
                for(int col =0;f < filas && col < cols; col ++)
                {
                    //Console.Write(matrix[f++, col] + " ");
                    if (pre != matrix[f++, col]) return false;
                }
                //Console.WriteLine();
            }


            return true;
        }


        static void Main(string[] args)
        {

            int[,] matrix = {
              { 1, 2, 3, 4 },
              { 5, 1, 2, 3 },
              { 9, 5, 1, 2 },
              { 5, 5, 5, 1 }
            };


            Console.WriteLine( IsToeplitzMatrix(matrix));


            Console.ReadLine();
        }
    }
}
