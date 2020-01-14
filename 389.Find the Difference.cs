https://leetcode.com/problems/find-the-difference/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {



        public static char FindTheDifference(string s, string t)
        {

            Dictionary<char, int> ds = new Dictionary<char, int>();
            foreach(char elem in s)
            {
                if (ds.ContainsKey(elem)) ds[elem]++;
                else ds[elem] = 1;
            }

            Dictionary<char, int> dt = new Dictionary<char, int>();
            foreach(char elem in t)
            {
                if (dt.ContainsKey(elem)) dt[elem]++;
                else dt[elem] = 1;
            }

            foreach(KeyValuePair<char, int> kvp in dt)
            {
                if (!ds.ContainsKey(kvp.Key)) return kvp.Key;
                else
                {
                    if (kvp.Value > ds[kvp.Key]) return kvp.Key;
                }
            }

            return ' ';
        }

        static void Main(string[] args)
        {

            //string s = "abcd";
            //string t = "abcde";

            string s = "aaaa";
            string t = "aaaaaaaaaaaaa";

            Console.WriteLine(FindTheDifference(s,t));


            Console.ReadLine();
        }
    }
}
