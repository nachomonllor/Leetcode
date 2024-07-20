using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    internal class Program
    {

        public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {


            var set1 = new HashSet<int>(nums1);
            var set2 = new HashSet<int>(nums2);

            var res1 = new List<int>();
            var res2 = new List<int>();

            foreach (var i in set1)
            {
                if (!set2.Contains(i))
                {
                    res2.Add(i);
                }
            }
            foreach (var i in set2)
            {
                if (!set1.Contains(i))
                {
                    res1.Add(i);
                }
            }

            IList<IList<int>> res = new List<IList<int>>();
            res.Add(res2);
            res.Add(res1);

            return res;

        }



        static void Main(string[] args)
        {


            Console.ReadLine();
        }
    }
}
