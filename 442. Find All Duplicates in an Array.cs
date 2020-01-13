https://leetcode.com/problems/find-all-duplicates-in-an-array/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        public static IList<int> FindDuplicates(int[] nums)
        {
            HashSet<int> hash = new HashSet<int>();

            List<int> ans = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!hash.Add(nums[i]))
                {
                    ans.Add(nums[i]);
                }
                hash.Add(nums[i]);
            }
            return ans;
        }

        static void Main(string[] args)
        {

            int[] arr = { 4, 3, 2, 7, 8, 2, 3, 1 };

            IList<int> ans = FindDuplicates(arr);

            foreach (int item in ans)
            {
                Console.Write(item + " ");
            }


            Console.ReadLine();

        }

    }
}
