using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication37
{
    class Program
    {

        public static int[][] GenerateMatrix(int n)
        {

            int[][] ans = new int[n][];
            for (int i = 0; i < n; i++)
            {
                ans[i] = new int[n];
            }

            int top_derecha = n-1;
            int top_abajo = n-1;
            int top_izquierda = 0;
            int top_arriba = 0;


            int cont = 1;
            for (int x = 0; x < n; x++)
            {

                //de derecha a izquierda
                for (int i = top_izquierda; i <= top_derecha; i++)
                {
                    ans[top_arriba][i] = cont++;
                }
                top_arriba++;

               

                //de arriba a abajo
                for (int i = top_arriba; i <= top_abajo; i++)
                {
                    ans[i][top_derecha] = cont++;
                }

                top_derecha--;
          

                //de derecha a izquierda
                for (int i = top_derecha; i >= top_izquierda; i--)
                {
                    ans[top_abajo][i] = cont++;
                }

                top_abajo--;


                //de abajo a arriba
                for (int i = top_abajo; i >= top_arriba; i--)
                {
                    ans[i][top_izquierda] = cont++;
                }
                top_izquierda++;
                
                    
            }

            return ans;
        }


        static void Main(string[] args)
        {

           // int n = 1;
            int n = 4;
            int[][] m = GenerateMatrix(n);

            for (int i = 0; i < m.Length; i++)
            {
                for (int j = 0; j < m[i].Length; j++)
                {
                    Console.Write(m[i][j] + " ");
                }
                Console.WriteLine();
            }



            Console.ReadLine();
        }

    }
}
