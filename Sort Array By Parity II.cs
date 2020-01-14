https://leetcode.com/problems/sort-array-by-parity-ii/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static  int[] SortArrayByParityII(int[] A)
        {
            //List<int> pares = new List<int>();
            //List<int> impares = new List<int>();
            Stack<int> pares = new Stack<int>();
            Stack<int> impares = new Stack<int>();

            for (int i =0; i<A.Length; i++)
            {
                if(A[i]%2==0)
                {
                    pares.Push(A[i]);
                }else
                {
                    impares.Push(A[i]);
                }
            }

            for(int  i =0; i<A.Length; i++)
            {
                if (i % 2 == 0) A[i] = pares.Pop();
                else A[i] = impares.Pop();
            }

            return A;
        }


        static void Main(string[] args)
        {
            int[] input = { 4, 2, 5, 7 };

            foreach(int elem in  SortArrayByParityII(input ))
            {
                Console.Write(elem + " ");
            }


            Console.ReadLine();
        }
    }
}
