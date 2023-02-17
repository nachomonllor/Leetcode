using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _908SmallestRangeI
{
    //https://leetcode.com/problems/smallest-range-i/description/
    class Program
    {
        public int SmallestRangeI(int[] nums, int k)
        {
            List<int> techo = new List<int>();
            List<int> piso = new List<int>();

            for(int i = 0; i < nums.Length; i++)
            {
                techo.Add(nums[i] + k);
                piso.Add(nums[i] - k);
            }
            return 0;
        }
        static void Main(string[] args)
        {
        }
    }
}
