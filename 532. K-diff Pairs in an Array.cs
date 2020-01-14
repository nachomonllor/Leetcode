https://leetcode.com/problems/k-diff-pairs-in-an-array/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        public static int FindPairs(int[] nums, int k)
        {

            if (k < 0) return 0;

            Dictionary<int, int> frec =
                new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (frec.ContainsKey(nums[i]))
                {
                    frec[nums[i]]++;
                }
                else
                {
                    frec[nums[i]] = 1;
                }
            }

            int pares = 0;
            if (k == 0)
            {
                foreach (KeyValuePair<int, int> kvp in frec)
                {
                    if (kvp.Value > 1)
                    {
                        pares++;
                    }
                }
                return pares;
            }

            int[] keys = frec.Keys.ToArray();

            for (int i = 0; i < keys.Length; i++)
            {
                if(frec.ContainsKey(k+keys[i]))
                {
                    pares++;
                }

            }

            return pares;

        } 

        static void Main(string[] args)
        {

            int[] input = { 1, 3, 1, 5, 4 };
            int k = 0;

            //int[] input = { 3, 1, 4, 1, 5 };
            //int k = 2;

            //int[] input = { 1, 2, 3, 4, 5 };
            //int k = 1; //4

            Console.WriteLine(FindPairs(input, k));



            Console.ReadLine();
        }
    }
}

