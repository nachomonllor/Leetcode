using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        public static bool CanThreePartsEqualSum(int[] A)
        {

            int[] sumas = new int[A.Length];
            int s = 0;
            
            for (int i = 0; i < A.Length; i++)
            {
                s += A[i];
                sumas[i] = s;
            }


            for (int i = 0; i < A.Length; i++)
            {
                if (2 * sumas[i] == s - sumas[i])
                {
                    int sum_aux = 0;
                    for (int j = i + 1; j < A.Length; j++)
                    {
                        sum_aux += A[j];
                        if (sum_aux == sumas[i])
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        static void Main(string[] args)
        {

            Console.ReadLine();
        }
    }
}
