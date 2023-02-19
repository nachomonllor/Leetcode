using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2273_Find_Resultant_Array_After_Removing_Anagrams
{
    class Program
    {
        public static IList<string> RemoveAnagrams(string[] words)
        {

            HashSet<string> hash = new HashSet<string>();

            IList<string> ans = new List<string>();

            foreach (string word in words)
            {
                string sorted = new string(word.OrderBy(c => c).ToArray());

                if (!hash.Contains(sorted))
                {
                    ans.Add(word);
                }
                hash.Add(sorted);

            }

            return ans;

        }
        static void Main(string[] args)
        {

            string[] words = { "abba", "baba", "bbaa", "cd", "cd" };
            //Output: ["abba","cd"]

            foreach (string item in RemoveAnagrams(words))
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();
        }
    }
}
