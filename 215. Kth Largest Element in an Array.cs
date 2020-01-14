https://leetcode.com/problems/kth-largest-element-in-an-array/#/description
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        public static int FindKthLargest(int[] nums, int k)
        {
            Array.Sort(nums);
            return nums[nums.Length - k];
        }

        static void Main(string[] args)
        {

            int[] a ={3,2,1,5,6,4};
            int k = 2;

            Console.WriteLine(FindKthLargest(a, k));

            Console.ReadLine();
        }
    }
}
