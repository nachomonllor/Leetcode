using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public class Solution
        {
            public class Solution
            {
                public static String convert(String s, int nRows)
                {
                    if (nRows == 1) return s;
                    char[,] matriz = new char[nRows, s.Length];
                    ZigZagCargar(s, matriz, nRows);
                    String concat = "";
                    for (int i = 0; i < nRows; i++)
                        for (int j = 0; j < s.Length; j++)
                            if (matriz[i, j] != '\0')//caracter vacio
                                concat += matriz[i, j];
                    return concat;
                }
                static void ZigZagCargar(String original, char[,] matriz, int nRows)
                {
                    int fila = 0, columna = 0;
                    int indOriginal = 0;
                    while (indOriginal < original.Length)
                    {
                        //bajar
                        while (fila < nRows)
                        {
                            if (indOriginal == original.Length) return;
                            matriz[fila, columna] = original[indOriginal]; indOriginal++;
                            fila++;
                        }
                        //subir
                        fila = nRows - 2; columna++;
                        while (fila >= 0)
                        {
                            if (indOriginal == original.Length) return;
                            matriz[fila, columna] = original[indOriginal]; indOriginal++;
                            fila--;
                            columna++;
                        }
                        fila = 1;
                        columna = columna - 1;
                    }
                }

            }
        }
    }
}
