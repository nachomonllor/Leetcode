https://leetcode.com/problems/longest-word-in-dictionary-through-deleting/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {

        public static List<string> Ordenar(List<string> words)
        {
            IEnumerable<string> query = from word in words
                                        orderby word.Length, word descending
                                        select word;

            return query.ToList();
        }

        //determina si s es subsecuencia de t
        public static bool isSubsequence(string s, string t)
        {
            int m = s.Length;
            int n = t.Length;

            int i = 0;
            for (int j = 0; j < n; j++)
            {
                if (s[i] == t[j]) i++;
                if (i == m) return true;
            }
            return false;
        }

        public static string FindLongestWord(string s, IList<string> d)
        {
            //SortedSet<string> ss = new SortedSet<string>();
            List<string> lista = new List<string>();

           

            for (int i = 0; i < d.Count; i++)
            {
             
                if(isSubsequence(d[i], s))
                {
                    lista.Add(d[i]);
                }
            }

            if (lista.Count == 0) return "";

            return Ordenar(lista).Last();

        }

        static void Main(string[] args)
        {
            //string s = "abpcplea";
            //string[] d = { "ale", "apple", "monkey", "plea" };

            string s = "aewfafwafjlwajflwajflwafj";
            string[] d = { "apple", "ewaf", "awefawfwaf", "awef", "awefe", "ewafeffewafewf" };


            Console.WriteLine(FindLongestWord(s, d.ToList()));

            Console.ReadLine();
        }
    }
}
