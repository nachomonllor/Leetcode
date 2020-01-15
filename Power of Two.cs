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
            public bool IsPowerOfTwo(int n)
            {
                if (n == 1 || n == 2) return true;
                long prod = 1;
                while (prod <= (long)n)
                {
                    prod *= 2;
                    if (prod == (long)n)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        

    }
}
