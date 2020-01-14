
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        public static  int[] SingleNumber(int[] nums)
        {
            Dictionary<int, int> hash = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int key = nums[i];
                if (hash.ContainsKey(key))
                {
                    hash[key]++;
                }
                else
                {
                    hash[key] = 1;
                }
            }

            int[] res = new int[2];
            int j = 0;
            foreach (KeyValuePair<int, int> kvp in hash)
            {
                if (kvp.Value == 1)
                {
                    res[j++] = kvp.Key;   
                }
            }
            return res;

        }



        static void Main(string[] args)
        {
            int[] res = SingleNumber(new int[] { 1, 2, 1, 3, 2, 5 });

            for (int i = 0; i < res.Length; i++)
            {
                Console.Write(res[i] + " ");
            }
            Console.ReadLine();

        }
    }
}
