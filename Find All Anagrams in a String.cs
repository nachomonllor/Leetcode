https://leetcode.com/problems/find-all-anagrams-in-a-string/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static bool CompararDiccionarios(Dictionary<char, int> a, Dictionary<char, int> b)
        {
            if (a.Count != b.Count) return false;

            foreach(KeyValuePair<char, int> kvp in a)
            {
                if (b.ContainsKey(kvp.Key))
                {
                    if (kvp.Value != b[kvp.Key]) return false;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }


        public static IList<int> FindAnagrams(string s, string p)
        {
            List<int> indices = new List<int>();

            if (s == "" || p == "" || p.Length > s.Length) return indices;

            Dictionary<char, int> dicP = new Dictionary<char, int>();
            for(char ch ='a'; ch<='z'; ch++) dicP[ch] = 0;
            for (int i = 0; i < p.Length; i++) dicP[p[i]]++;
              
            string subs = s.Substring(0, p.Length);
            Dictionary<char, int> dicSubs = new Dictionary<char, int>();

            for (char ch = 'a'; ch <= 'z'; ch++) dicSubs[ch] = 0;
            for (int i = 0; i < subs.Length; i++) dicSubs[subs[i]]++;

            for (int i = 0; i + p.Length < s.Length ; i++)
            {
                if (CompararDiccionarios(dicSubs, dicP))
                {
                    indices.Add(i);
                }
                if (dicSubs.ContainsKey(s[i]))
                {
                    if (dicSubs[s[i]] == 0)
                    {
                        dicSubs[s[i]] = 0;
                    }
                    else if (dicSubs[s[i]] > 0)
                    {
                        dicSubs[s[i]]--;
                    }
                }

                dicSubs[s[i + p.Length]]++;
            }

            if (CompararDiccionarios(dicSubs, dicP))
            {
                indices.Add(s.Length-p.Length);
            }

            return indices;
        }

        static void Main(string[] args)
        {
            //string s= "cbaebabacd";
            //string p = "abc";

            string s = "abab";
            string p = "ab";

            foreach (int elem in FindAnagrams(s,p)  )
            {
                Console.Write(elem + " ");
            }


            Console.ReadLine();
        }
    }
}
