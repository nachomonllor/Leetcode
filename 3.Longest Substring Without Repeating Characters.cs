https://leetcode.com/problems/longest-substring-without-repeating-characters/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static int LengthOfLongestSubstring(string s)
        {
            if (s.Length == 0) return 0;
            HashSet<char> ventana = new HashSet<char>();

            int i = 0;
            while (i < s.Length && ventana.Add(s[i]))
            {
                i++;
            }

            i = 0;
            int len = ventana.Count;
            int max_len = len;

            //ventana.Remove(s[0]);

            for (; i < s.Length; i++)
            {
                len = ventana.Count;
                while (i + len < s.Length && ventana.Add(s[i + len]))
                {
                    len++;
                }
                max_len = Math.Max(max_len, ventana.Count);
                ventana.Remove(s[i]);
            }

            return max_len;
        }

        static void Main(string[] args)
        {
             // string s = "abcabcbb";
            //string s = "aab";
            //string s = "bbbbb";
            //string s = "tmmzuxt";
            //string s = "pwwkew";//3
            string s = "pwwwkew";//3
            //string s = "gsqygebs";//6

            Console.WriteLine( LengthOfLongestSubstring(s));

            Console.ReadLine();
        }
    }
}
