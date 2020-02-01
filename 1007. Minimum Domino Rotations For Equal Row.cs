https://leetcode.com/problems/minimum-domino-rotations-for-equal-row/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public static  int MinDominoRotations(int[] A, int[] B)
        {
         
            int[] contA = new int[7];
            int[] contB = new int[7];
            int[] contAmbos = new int[7];

            for (int i = 0; i < A.Length; i++)
            {
                contA[A[i]]++;
                contB[B[i]]++;
                if (A[i] == B[i])
                {
                    contAmbos[A[i]]++;
                }

            }

            for (int i = 1; i < 7; i++)
            {
                if (contA[i] + contB[i] - contAmbos[i] >= A.Length)
                {

                   // return Math.Min(contA[i], contB[i]) - contAmbos[i];
                    return A.Length - Math.Max(contA[i], contB[i]);
                }
            }
            return -1;

         

        }
        public static  int MinDominoRotations(int[] A, int[] B)
        {
         


            List<int[]> lista = new List<int[]>();
            for (int i = 0; i <= 6; i++)
            {
                lista.Add(new int[2]);
            }
            bool[] hash = new bool[7];
            for (int i = 0; i <=6; i++)
            {
                hash[i] = true;
            }

            for (int i = 0; i < A.Length; i++)
            {
                for (int num = 1; num <= 6; num++)
                {
                    if (A[i] == num)
                    {
                        lista[num][0]++;
                    }
                    if (B[i] == num)
                    {
                        lista[num][1]++;
                    }
                    if (A[i] != num && B[i] != num)
                    {
                        hash[num] = false;
                    }
                }
            }

            int minimo_numero_rotaciones = A.Length + 1;

            for (int num = 1; num <= 6; num++)
            {
                if (hash[num])
                {
                    int max = Math.Max(lista[num][0], lista[num][1]);
                    minimo_numero_rotaciones = Math.Min(minimo_numero_rotaciones, A.Length - max);
                }
            }

            if (minimo_numero_rotaciones == A.Length + 1) return -1;

            return minimo_numero_rotaciones;

        }

        static void Main(string[] args)
        {
            int[] A = { 2, 1, 2, 4, 2, 2 };
            int[] B = { 5, 2, 6, 2, 3, 2 };

            Console.WriteLine( MinDominoRotations(A, B));


            Console.ReadLine();
        }
    }
}

