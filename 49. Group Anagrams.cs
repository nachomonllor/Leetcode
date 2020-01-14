
https://leetcode.com/problems/group-anagrams/description/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> diccio = new Dictionary<string, List<string>>();

            foreach (string elem in strs)
            {
                char[] sort = elem.ToCharArray();
                Array.Sort(sort);
                diccio[new string( sort)] = new List<string>();
            }

            foreach (string elem in strs)
            {

                char[] sort = elem.ToCharArray();
                Array.Sort(sort);
                diccio[new string( sort)].Add(elem);
            }

            List<List<string>> res = new List<List<string>>();


            foreach (KeyValuePair<string, List<string>> kvp in diccio)
            {
                List<string> aux = new List<string>(kvp.Value);
                aux.Sort();
                res.Add(aux);
            }


            var converted = ((IList<IList<string >>)res.Cast<IList<string >>().ToList());

            return converted;

        }

        static void Main(string[] args)
        {

            string[] s = { "eat", "tea", "tan", "ate", "nat", "bat" };

            GroupAnagrams(s);

            Console.ReadLine();

        }
    }
}
