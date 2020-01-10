
https://leetcode.com/problems/split-a-string-in-balanced-strings/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        public static int BalancedStringSplit(string s)
        {
            int ans = 0;
            int R = 0, L = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'R')
                {
                    R++;
                }
                if (s[i] == 'L')
                {
                    L++;
                }
                if (L == R)
                {
                    ans++;
                    L = 0;
                    R = 0;
                }
            }

            return ans;
        }

        static void Main(string[] args)  
        {
            string s = "RLRRLLRLRL";
            Console.WriteLine(BalancedStringSplit(s));

            Console.ReadLine();

        }
    }
}
