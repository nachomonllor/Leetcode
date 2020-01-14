https://leetcode.com/problems/fair-candy-swap/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        public static int[] fairCandySwap(int[] A, int[] B)
        {
            int sa = A.Sum();
            int sb = B.Sum();

            HashSet<int> hashA = new HashSet<int>(A);
            HashSet<int> hashB = new HashSet<int>(B);

            int dif = Math.Abs(sa - sb);

            int prom = (sa + sb) / 2;


            int[] res = new int[2];
            int aux = sa;
            for (int i = 0; i < A.Length; i++)
            {
                int resto = sa - A[i];
                if (hashB.Contains(prom - resto))
                {
                    // Console.WriteLine(A[i] + " "+   (prom - resto ));
                    res = new  int[] { A[i], (prom - resto) };
	
			break;
                    
                }

            }
            return res;
        }

        static void Main(string[] args)
        {

            //int[] A = { 1, 2, 5 };
            //int[] B = { 2, 4 };

            int[] A = { 2 };
            int[] B = { 1, 3 };


           foreach(int elem in fairCandySwap(A, B))
            {
                Console.Write(elem + " ");
            }

            Console.ReadLine();
        }
    }
}
