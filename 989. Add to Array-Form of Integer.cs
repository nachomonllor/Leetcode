https://leetcode.com/problems/add-to-array-form-of-integer/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        public static List<int> AddToArrayForm(int[] A, int K)
        {

            int nk = Math.Max(A.Length, K.ToString().Length);

            int[] acopia;
            if (nk > A.Length)
            {
               // acopia = new int[nk];
                //for (int i = 0; i < nk; i++)
                //{
                //    acopia[i] = A[nk-i];
                //}
                List<int> aux = A.ToList();
                int resto = aux.Count;
                for (int i = 0; i < nk - resto; i++)
                {
                    aux.Insert(0, 0);
                }
                acopia = aux.ToArray();
            }
            else
            {
                acopia = A.ToArray();
            }

            int[] arr_k = new int[nk];

            for (int i = nk - 1; i >= 0; i--)
            {
                arr_k[i] = (K % 10);
                K /= 10;
            }

            List<int> ans = new List<int>();
            int mellevo = 0;
            for (int i = nk - 1; i >= 0; i--)
            {
                //Console.Write(arr_k[i] + " ");
                int sum = arr_k[i] + acopia[i] + mellevo;
                if (sum > 9)
                {
                    ans.Insert(0, sum % 10);
                    mellevo = sum / 10 % 10;
                }
                else
                {
                    ans.Insert(0, sum % 10);
                    mellevo = 0;
                }
            }

            if (mellevo > 0)
            {
                ans.Insert(0, mellevo);
            }

            return ans;
        }

        static void Main(string[] args)
        {

            //int[] A = { 1, 2, 0, 0 };
            //int K = 9444;

            //int[] A = {2,7,4};
            //int k = 181;

            //int [] A = {0};
            //int k = 23;

            //int[] A = { 1 };
            //int k = 33;

           int[] A = {0};
           int k = 10000;

            List<int> ans = AddToArrayForm(A, k);

            foreach (int item in ans)
            {
                Console.Write(item + " ");
            }


            Console.ReadLine();
        }

    }

}

