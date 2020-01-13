https://leetcode.com/problems/counting-bits/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        public static int[] CountBits(int num)
        {
            List<int> lista =
                new List<int>();
            for (int i = 1; i <= num; i++)
            {
                string result = Convert.ToString(Convert.ToInt32(i.ToString(), 10), 2);
                int u = 0;
                for (int j = 0; j < result.Length; j++)
                {
                    if (result[j] == '1') u++;
                }
                lista.Add(u);
            }
            return lista.ToArray();
        }

        static void Main(string[] args)
        {
            int[] arr = CountBits(3);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.ReadLine();

        }
    }
}

