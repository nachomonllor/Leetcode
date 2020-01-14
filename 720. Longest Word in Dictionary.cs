https://leetcode.com/problems/longest-word-in-dictionary/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        public static string LongestWord(string[] words)
        {

            HashSet<string> hash = new HashSet<string>(words);


           // List<string> sort  = SortByLength(words);
            Array.Sort(words, (x, y) => y.Length.CompareTo(x.Length));
            List<string> candidatos = new List<string>();
            int max_len = 0;
            for (int i = 0; i < words.Length; i++)
            {
                int j = 0;
                int len = words[i].Length;
                string subs = words[i].Substring(0, len);
                while (hash.Contains(subs))
                {
                    len--;
                    subs = subs.Substring(0, len);
                  
                }
                if (len == 0)
                {
                    if (words[i].Length >= max_len)
                    {
                        candidatos.Add(words[i]);
                        max_len = words[i].Length;
                    }
                }
            }

            candidatos.Sort();
            return candidatos.First();
        }



        static void Main(string[] args)
        {
            //string[] words = { "a", "banana", "app", "appl", "ap", "apply", "apple" };
            string[] words = { "yo", "ew", "fc", "zrc", "yodn", "fcm", "qm", "qmo", "fcmz", "z", "ewq", "yod", "ewqz", "y" };

        Console.WriteLine(LongestWord(words));

            Console.ReadLine();
        }
    }
}
