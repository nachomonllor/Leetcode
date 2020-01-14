https://leetcode.com/problems/find-and-replace-pattern/
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ConsoleApplication1
{
    class Program
    {
        public static bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length) return false;
            Dictionary<char, char> diccio = new Dictionary<char, char>();

            for (int i = 0; i < s.Length; i++)
            {
                char key = s[i], val = t[i];
                if (diccio.ContainsKey(key))
                {
                    if (diccio[key] != val)
                    {
                        return false;
                    }
                }
                else
                {
                    if (!diccio.ContainsValue(val))
                    {
                        diccio[key] = val;
                    }
                    else
                    {
                        return false;
                    }
                }

            }
            return true;

        }

        public static IList<string> FindAndReplacePattern(string[] words, string pattern)
        {

            Dictionary<string, string> dic =
                new Dictionary<string, string>();

            List<string> lista =
                new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                if (IsIsomorphic(pattern, words[i]))
                {
                    lista.Add(words[i]);
                }
            }
            return (IList<string>)lista;

        }

        static void Main(string[] args)
        {   
            
            string[] words = {"abc","deq","mee","aqq","dkd","ccc"};
            string pattern = "abb";

            IList<string> lista = FindAndReplacePattern(words, pattern);

            foreach (string item in lista)
            {
                Console.Write(item + " ");
            }


            Console.ReadLine();
        }       
            
            
    }       
}
