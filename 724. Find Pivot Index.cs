https://leetcode.com/problems/find-pivot-index/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {


        public int PivotIndex(int[] nums)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            int sum = 0;
            int total = nums.Sum();

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                dic[i] = sum;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                {
                    if (total - nums[0] == 0) return 0;
                }
                else
                {
                    if (dic[i - 1] == total - dic[i])
                    {
                        return i;
                    }
                }
            }

            return -1;
        }


        static void Main(string[] args)
        {

          



            Console.ReadLine();

        }
    }
}
