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
            public string[] FindWords(string[] words)
            {
                string[] rows = { "qwertyuiop", "asdfghjkl", "zxcvbnm" };
                List<string> ans = new List<string>();
                foreach (string w in words)
                {
                    int i_row = 0;
                    while (i_row < rows.Length)
                    {
                        int i = 0;
                        while (i < w.Length && rows[i_row].Contains(w.ToLower()[i]))
                        {
                            i++;
                        }
                        if (i == w.Length)
                        {
                            ans.Add(w);
                        }
                        i_row++;
                    }
                }
                return ans.ToArray();
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
