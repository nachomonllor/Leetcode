using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public static bool IsValidSudoku(char[,] board)
        {

            //comprobar fila por fila
            for (int i = 0; i < 9; i++)
            {
                HashSet<char> filaActual = new HashSet<char>();
                for (int j = 0; j < 9; j++)
                {
                    if (char.IsNumber(board[i, j]))
                    {
                        if (filaActual.Contains(board[i, j]))
                        {
                            return false;
                        }
                        filaActual.Add(board[i, j]);
                    }
                }
            }

            //comprobar columna por columna
            for (int j = 0; j < 9; j++)
            {
                HashSet<char> colActual = new HashSet<char>();
                for (int i = 0; i < 9; i++)
                {
                    if (char.IsNumber(board[i, j]))
                    {
                        if (colActual.Contains(board[i, j]))
                        {
                            return false;
                        }
                        colActual.Add(board[i, j]);
                    }
                }

            }

            for (int fila = 0; fila < 9; fila += 3)
            {
                for (int col = 0; col < 9; col += 3)
                {
                    HashSet<int> cuadrante = new HashSet<int>();
                    for (int i = fila; i < fila + 3; i++)
                    {
                        for (int j = col; j < col + 3; j++)
                        {
                            if (char.IsNumber(board[i, j]))
                            {
                                if (cuadrante.Contains(board[i, j]))
                                {
                                    return false;
                                }
                                cuadrante.Add(board[i, j]);
                            }
                        }
                    }

                }

            }

            return true;
        }


        static void Main(string[] args)
        {
            char[,] board = new  char[9,9];
            bool b = IsValidSudoku(board);
            Console.WriteLine(b);

            Console.ReadLine();
             
        }

    }
}
