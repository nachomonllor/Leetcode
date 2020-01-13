https://leetcode.com/problems/group-anagrams/description/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54
{
    class Program
    {

        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string >> hm =
               new Dictionary<string, List<string>>();

            for (int i = 0; i < strs.Length; i++)
            {
                String actual = strs[i];
                char[] ordAux = actual.ToCharArray();
                Array.Sort(ordAux);
                string ord = new string(ordAux);

                if (hm.ContainsKey(ord))
                {
                    List<String> aux = hm[ord];
                    aux.Add(actual);
                    hm[ord] = aux;
                }
                else
                {
                    List<String> aux = new List<string>();
                    aux.Add(actual);
                    hm[ord] = aux;
                }
            }

            IList<IList<String>> lista =
                    new List<IList<string>>();

            foreach (string key in hm.Keys)
            //foreach(KeyValuePair<string, List<string>> kvp in hm)
            {
                List<String> aux = new List<string>();
                for (int i = 0; i < hm[key].Count; i++)
                {
                    //aux.add(hm.get(key).get(i));
                    aux.Add(hm[key][i]);
                }
                aux.Sort();
                lista.Add(aux);
            }
            return lista;

        }

        static void Main(string[] args)
        {

            String[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };
            IList<IList<String>> res = GroupAnagrams(strs);

            foreach (List<String> lista in res)
            {
                foreach (String elem in lista)
                {
                    Console.Write(elem + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
