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
            public bool IsPowerOfFour(int num)
            {
                if (num <= 0) return false;
                if (num == 1) return true;
                while (num > 0)
                {
                    if (num % 4 == 0)
                    {
                        num /= 4;
                        if (num == 1)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                return false;
            }
        }
    }
}
