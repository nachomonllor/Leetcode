https://leetcode.com/problems/maximum-average-subarray-i/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        public static double FindMaxAverage(int[] nums, int k)
        {
            double sum = 0;
            int n = nums.Length;
            if (k > n) return 0;
            for (int i = 0; i < k; i++)
            {
                sum += nums[i];
            }
            double avg = sum / (double)k;
            double max_avg = avg;

            for (int i = 0; i + k < n; i++)
            {
                sum -= nums[i];
                sum += nums[i + k];
                max_avg = Math.Max(max_avg, sum / (double)k);
            }
            return max_avg;

        }

        static void Main(string[] args)
        {

            int[] d = { 1, 12, -5, -6, 50, 3 };//12.75
            int k = 4;

            Console.WriteLine(FindMaxAverage(d, k));



            Console.ReadLine();
        }
    }
}
