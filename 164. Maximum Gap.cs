using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public class Solution
        {
            public int MaximumGap(int[] nums)
            {
                if (nums.Length < 2) return 0;
                Array.Sort(nums);
                int max = 0;
                for (int i = 1; i < nums.Length; i++)
                {
                    max = Math.Max(max, nums[i] - nums[i - 1]);
                }
                return max;

                // https://leetcode.com/problems/maximum-gap/description/ 2/2



            }
            static void Main(string[] args)
            {
            }
        }
    }
}
