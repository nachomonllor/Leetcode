using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication38
{
    class Program
    {
     

        public static IList<int> SpiralOrder(int[][] matrix)
        {

           

            IList<int> ans = new List<int>();
            if (matrix == null || matrix.Length == 0) return ans;

            int n = matrix.Length;
            int m = matrix[0].Length;

            int top_derecha = m - 1;
            int top_abajo = n - 1;
            int top_izquierda = 0;
            int top_arriba = 0;



            // int cont = 1;
            //for (int x = 0; x < n; x++)
            while (top_arriba <= top_abajo && top_izquierda <= top_derecha)
            {
                if (top_arriba <= top_abajo && top_izquierda <= top_derecha)
                {
                    //de derecha a izquierda
                    for (int i = top_izquierda; i <= top_derecha; i++)
                    {
                        ans.Add(matrix[top_arriba][i]); // = cont++;
                    }

                }
                top_arriba++;


                if (top_arriba <= top_abajo && top_izquierda <= top_derecha)
                {
                    //de arriba a abajo
                    for (int i = top_arriba; i <= top_abajo; i++)
                    {
                        ans.Add(matrix[i][top_derecha]); // = cont++;
                    }
                }

                top_derecha--;


                if (top_arriba <= top_abajo && top_izquierda <= top_derecha)
                {
                    //de derecha a izquierda
                    for (int i = top_derecha; i >= top_izquierda; i--)
                    {
                        ans.Add(matrix[top_abajo][i]); // = cont++;
                    }

                }

                top_abajo--;


                if (top_arriba <= top_abajo && top_izquierda <= top_derecha)
                {
                    //de abajo a arriba
                    for (int i = top_abajo; i >= top_arriba; i--)
                    {
                        ans.Add(matrix[i][top_izquierda]); // = cont++;
                    }
                }
                top_izquierda++;


            }

            return ans;
            

        }

        static void Main(string[] args)
        {

            //int[][] Input =
            //{
            //   new int[]  { 1, 2, 3 },
            //   new int[] { 4, 5, 6 },
            //    new int [] { 7, 8, 9 }
            //};

            int[][] Input = {
                new int[] {1,2,3,4},
                new int[] {5,6,7,8},
                new int[] {9,10,11,12}
                            };

            //int[][] Input = {
            //    new int[] {1,  2, 3, 4},
            //    new int[] {10,11,12, 5},
            //    new int[] {9,  8, 7, 6}
            //                };


            IList<int> lista = SpiralOrder(Input);


            foreach (int item in lista)
            {
                Console.Write(item + " ");
            }


            Console.ReadLine();

        }
    }
}
