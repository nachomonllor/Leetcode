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
            public bool ContainsDuplicate(int[] nums)
            {
                HashSet<int> hash = new HashSet<int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    if (hash.Contains(nums[i]))
                    {
                        return true;
                    }
                    hash.Add(nums[i]);
                }
                return false;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
