https://leetcode.com/problems/intersection-of-two-arrays-ii/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            var da = new Dictionary<int, int>();
            foreach (int elem in nums1)
            {
                if (da.ContainsKey(elem))
                {
                    da[elem]++;
                }
                else
                {
                    da[elem] = 1;
                }
            }
            var db = new Dictionary<int, int>();
            foreach (int elem in nums2)
            {
                if (db.ContainsKey(elem))
                {
                    db[elem]++;
                }
                else
                {
                    db[elem] = 1;
                }
            }

            List<int> ans = new List<int>();

            foreach (KeyValuePair<int, int> kvp in da)
            {
                if (db.ContainsKey(kvp.Key))
                {
                    for (int i = 0; i < Math.Min(kvp.Value, db[kvp.Key]); i++)
                    {
                        ans.Add(kvp.Key);
                    }
                }
            }
            return ans.ToArray();

        }

        static void Main(string[] args)
        {

           int[]  nums1 = {1, 2, 2, 1};
           int[] nums2 = { 2, 2 };

           int[] res = Intersect(nums1, nums2);

           foreach (int elem in res)
           {
               Console.Write(elem + " ");
           }

            Console.ReadLine();
        }

    }
}
