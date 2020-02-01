using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        public static int F(string s)
        {
            char min_char = 'z';
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] < min_char)
                {
                    min_char = s[i];
                }
            }

            int ans = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == min_char)
                {
                    ans++;
                }
            }
            return ans;
        }

        public static int[] NumSmallerByFrequency(string[] queries, string[] words)
        {
            List<int> valor_queries = new List<int>();
            for (int i = 0; i < queries.Length; i++)
            {
                valor_queries.Add(F(queries[i]));
            }
            List<int> valor_words = new List<int>();
            for (int i = 0; i < words.Length; i++)
            {
                valor_words.Add(F(words[i]));
            }

            List<int> ans = new List<int>();
            for (int i = 0; i <  queries .Length; i++)
            {
                int cont = 0;
                for (int j = 0; j < words.Length; j++)
                {
                    if (  valor_queries[i] < valor_words[j])
                    {
                        cont++;
                    }
                }
                ans.Add(cont);
            }
            return ans.ToArray();

        }

        static void Main(string[] args)
        {
        
            string[] queries = {"bbb","cc"};
            string[] words = { "a", "aa", "aaa", "aaaa" };

            int[] ans = NumSmallerByFrequency(queries, words);

            for (int i = 0; i < ans.Length; i++)
            {
                Console.Write(ans[i] + " ");
            }

            Console.ReadLine();

        }
    }
}
