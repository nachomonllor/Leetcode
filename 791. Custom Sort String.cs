https://leetcode.com/problems/custom-sort-string/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {


        public static string CustomSortString(string S, string T)
        {

           // HashSet<char> hash_t = new HashSet<char>(T.ToCharArray());

            Dictionary<char, int> hash_t =
                new Dictionary<char, int>();
            for (int i = 0; i < T.Length; i++)
            {
                if (hash_t.ContainsKey(T[i]))
                {
                    hash_t[T[i]]++;
                }
                else
                {
                    hash_t[T[i]] = 1;
                }
            }

            List<char> sobra = new List<char>();
            string ans = "";
            for (int i = 0; i < S.Length; i++)
            {
                if (hash_t.ContainsKey(S[i]))
                {
                    ans += new string (S[i], hash_t[S[i]]);
                    hash_t.Remove(S[i]);
                }
            }

            foreach (KeyValuePair<char, int> kvp in hash_t)
            {
                ans += new string( kvp.Key, kvp.Value);
            }

            return ans;

        }

        static void Main(string[] args)
        {

            string S = "cba";
            string T = "abcd";


            Console.WriteLine(CustomSortString(S, T));


            Console.ReadLine();

        }

    }
}
