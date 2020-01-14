https://leetcode.com/problems/set-mismatch/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {

        public static int[] FindErrorNums(int[] nums)
        {

            int[] ans = new int[2];
            int max = nums.Length;

            int[] frec = new int[max + 1];

            for(int i =0; i<nums.Length; i++)
            {
                frec[nums[i]]++;
            }

            for(int i = 1; i< nums.Length+1; i++)
            {
                if(frec[i]==2)
                {
                    //ans.Add(i);
                    ans[0] = i;
                }
                if(frec[i] == 0)
                {
                    //ans.Add(i);
                    ans[1] = i;
                }
            }

            return ans.ToArray();
        }

        static void Main(string[] args)
        {
           //int[]  nums = { 1, 2, 2, 4};
            int[] nums = { 2, 2 };//[2,1]

            foreach (int elem in FindErrorNums(nums))
            {
                Console.Write(elem + " ");
            }

            Console.ReadLine();
        }
    }
}
