https://leetcode.com/problems/sort-array-by-parity/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        public static int[] SortArrayByParity(int[] A)
        {
            for (int i = 1; i < A.Length; i++)
            {
                int indice = i;
                while (indice > 0 && A[indice - 1] %2 !=0 && A[indice] %2==0)
                {
                    int temp = A[indice - 1];
                    A[indice - 1] = A[indice];
                    A[indice] = temp;
                    indice--;
                }
            }
            return A;

        }

        static void Main(string[] args)
        {
            int[] input = { 3, 1, 2, 4 };

            foreach(int elem in SortArrayByParity(input))
            {
                Console.Write(elem + " ");

            }

            Console.ReadLine();
        }
    }
}

   public static int[] SortArrayByParity(int[] A)
        {
            List<int> pares = new List<int>();
            List<int> impares = new List<int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                {
                    pares.Add(A[i]);
                }
                else
                {
                    impares.Add(A[i]);
                }

            }

            List<int> concat = new List<int>();
            concat.AddRange(pares);
            concat.AddRange(impares);

            return concat.ToArray();
        }
