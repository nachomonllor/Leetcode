https://leetcode.com/problems/find-the-duplicate-number/

--ACEPTADO—
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        public int FindDuplicate(int[] nums)
        {
            Dictionary<int, int> diccio = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int key = nums[i];
                if (diccio.ContainsKey(key))
                {
                    diccio[key]++;
                }
                else
                {
                    diccio[key] = 1;
                }
            }

            foreach (KeyValuePair<int, int> kvp in diccio)
            {
                if (kvp.Value > 1) return kvp.Key;

            }
            return -1;


        }

        static void Main(string[] args)
        {
        }

    }
}
