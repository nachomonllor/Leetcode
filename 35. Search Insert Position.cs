https://leetcode.com/problems/search-insert-position/description/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {

        public static int SearchInsert(int[] nums, int target)
        {
            SortedSet<int> hs = new SortedSet<int>(nums);
            hs.Add(target);
            return Array.IndexOf(hs.ToArray(), target);
        }

        static void Main(string[] args)
        {

            //int[] arr = { 1 };
            //int target = 0;

            int[] arr = {1};
            int target =   2  ;

            Console.WriteLine(SearchInsert(arr, target));

            Console.ReadLine();
        }
    }
}
