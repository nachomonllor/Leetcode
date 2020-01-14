https://leetcode.com/problems/longest-continuous-increasing-subsequence/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {


        public static int findLengthOfLCIS(int[] nums)
        {
            if (nums.Length == 0) return 0;

            //List<int> longest = new List<int>();
            int longest = 1;
            //longest.Add(nums[0]);
            int maxLen = 0;
            int pre = nums[0];

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > pre)
                {
                    longest++;      
                    //longest.Add(nums[i]);
                }
                else
                {
                    maxLen = Math.Max(maxLen, longest);
                    //longest = new List<int>();
                    //longest.Add(nums[i]);
                    longest = 1;
                }
                pre = nums[i];
            }
            maxLen = Math.Max(maxLen, longest);

            return maxLen;
        }

        static void Main(string[] args)
        {
            //int[] input = { 1, 3, 5, 4, 7 };
            int[] input = { 1, 3, 5, 7 };
             Console.WriteLine( findLengthOfLCIS(input));



            Console.ReadLine();
        }
    }
}
