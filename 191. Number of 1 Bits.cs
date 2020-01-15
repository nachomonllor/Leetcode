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

            public int HammingWeight(uint n)
            {
                return Convert.ToString(n, 2).Count(e => e == '1');
            }


            static void Main(string[] args)
            {
            }
        }
    }
}
