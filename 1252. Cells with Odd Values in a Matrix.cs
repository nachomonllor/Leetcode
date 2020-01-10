 
https://leetcode.com/problems/cells-with-odd-values-in-a-matrix/submissions/

public static int OddCells(int n, int m, int[][] indices)
        {
            int[] filas = new int[n];
            int[] cols = new int[m];

            for (int i = 0; i < indices.Length; i++)
            {
                filas[indices[i][0]]++;
                cols[indices[i][1]]++;
            }

            int[][] matriz = new int[n][];
            for (int i = 0; i < n; i++)
            {
                matriz[i] = new int[m];
            }

            int odd = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matriz[i][j] += filas[i] + cols[j];
                    if (matriz[i][j] % 2 != 0) odd++;
                }
            }

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write(matriz[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}


           

            return odd;
        }
