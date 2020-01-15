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

            public bool RotateString(string A, string B)
            {
                return (A.Length == B.Length) && (A + A).Contains(B);
            }

        }


    }
}
