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
            public int FindComplement(int num)
            {

          //  https://leetcode.com/problems/numbercomplement/#/

                string b = Convert.ToString(num, 2);
                string comp = "";
                for (int i = 0; i < b.Length; i++)
                {
                    if (b[i] == '1') comp += '0';
                    else comp += '1';
                }
                return Convert.ToInt32(comp, 2);
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
