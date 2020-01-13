https://leetcode.com/problems/majority-element-ii/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        public static IList<int> MajorityElement(int[] nums)
        {
            var diccio = new Dictionary<int, int>();
            foreach (int elem in nums)
            {
                if (diccio.ContainsKey(elem))
                {
                    diccio[elem]++;
                }
                else
                {
                    diccio[elem] = 1;
                }
            }
            IList<int> ans = new List<int>();
            foreach (KeyValuePair<int, int> kvp in diccio)
            {
                if (kvp.Value > nums.Length / 3)
                {
                    ans.Add(kvp.Key);
                }
            }
            return ans;

        }


        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 1, 2, 1, 2, 1, 2, 3 };
            IList<int> res = MajorityElement(nums);

            foreach (int elem in res)
            {
                Console.Write(elem + " ");
            }

            Console.ReadLine();
        }
    }
}

