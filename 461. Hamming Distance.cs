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
            public int HammingDistance(int x, int y)
            {
                string a = Convert.ToString(x, 2);
                string b = Convert.ToString(y, 2);
                if (a.Length < b.Length) a = new string('0', b.Length - a.Length) + a;
                if (b.Length < a.Length) b = new string('0', a.Length - b.Length) + b;
                int ans = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] != b[i]) ans++;
                }
                return ans;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}