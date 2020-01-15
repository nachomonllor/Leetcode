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

            public uint reverseBits(uint n)
            {
                string bin =
                new string(Convert.ToString(n, 2).ToArray());
                string rev = new string((new string('0', 32 - bin.Length) + bin).Reverse().ToArray());
                return Convert.ToUInt32(rev, 2);
            }


        }



    }
}
