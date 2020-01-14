https://leetcode.com/problems/largest-number-at-least-twice-of-others/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        public static int DominantIndex(int[] nums)
        {
            if (nums.Length == 1) return nums[0];
            int max = nums.Max();
            int ind = Array.IndexOf(nums, max);
            
            for(int i =0; i<nums.Length; i++)
            {
                if(max < nums[i] * 2)
                {
                    return -1;
                }
            }


            return ind ;
        }


        static void Main(string[] args)
        {

          



            Console.ReadLine();

        }
    }
}
