https://leetcode.com/problems/degree-of-an-array/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {


        public static int FindShortestSubArray(int[] nums)
        {
            Dictionary<int, int[]> dic = new Dictionary<int, int[]>();

            int max_frec = 0;
            for (int i = 0; i < nums.Length; i++)
            {

                if (dic.ContainsKey(nums[i]))
                {
                    dic[nums[i]][0]++;
                    dic[nums[i]][2] = i;
                    if (dic[nums[i]][0] >= max_frec)
                    {
                        max_frec = dic[nums[i]][0];
                    }
                }
                else
                {
                    dic[nums[i]] = new int[3];
                    dic[nums[i]][0] = 1;
                    dic[nums[i]][1] = i;
                }
            }

            int min_len = int.MaxValue;
            foreach (KeyValuePair<int, int[]> kvp in dic)
            {
                if (kvp.Value[0] == max_frec)
                {
                    min_len = Math.Min(min_len, kvp.Value[2] - kvp.Value[1] + 1);
                }
            }

            if (min_len == 0 || min_len == int.MaxValue) return 1;

            return min_len;

        }

        static void Main(string[] args)
        {


            Console.ReadLine();
        }
    }
}
