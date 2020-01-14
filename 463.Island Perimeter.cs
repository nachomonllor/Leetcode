https://leetcode.com/problems/island-perimeter/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {



        public static int IslandPerimeter(int[,] grid)
        {
            int perimetro = 0;
            int filas = grid.GetLength(0);
            int cols = grid.GetLength(1);
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (grid[i, j] == 1)
                    {
                        if (i - 1 < 0) perimetro++;
                        if (j - 1 < 0) perimetro++;
                        if (i + 1 >= filas) perimetro++;
                        if (j + 1 >= cols) perimetro++;

                        if (i - 1 >= 0)
                        {
                            if (grid[i - 1, j] == 0) perimetro++;
                        }
                        if (i + 1 < filas)
                        {
                            if (grid[i + 1, j] == 0) perimetro++;
                        }
                        if (j - 1 >= 0)
                        {
                            if (grid[i, j - 1] == 0) perimetro++;
                        }
                        if (j + 1 < cols)
                        {
                            if (grid[i, j + 1] == 0) perimetro++;
                        }

                    }

                }
            }

            return perimetro;

        }

        static void Main(string[] args)
        {

            int[,] Input =
             {
             { 0, 1, 0, 0 },
             { 1, 1, 1, 0 },
             { 0, 1, 0, 0 },
             { 1, 1, 0, 0 }
             };


            Console.WriteLine(IslandPerimeter(Input));


            Console.ReadLine();
        }
    }
}
