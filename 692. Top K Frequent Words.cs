https://leetcode.com/problems/top-k-frequent-words/description/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp59
{
    class Program
    {

        public static  IList<string> TopKFrequent(string[] words, int k)
        {
            IList<string> topk = new List<string>();
            if (k == 0) return topk;
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            for(int i =0; i<words.Length; i++)
            {
                if(dictionary.ContainsKey(words[i]))
                    dictionary[words[i]]++;
                else
                    dictionary[words[i]] = 1;
            }

            SortedDictionary<int, List<string>> ordenado =
                new SortedDictionary<int, List<string>>();

            foreach(KeyValuePair<string, int> kvp in dictionary)
            {
                if (ordenado.ContainsKey(dictionary[kvp.Key]))
                {
                    ordenado[dictionary[kvp.Key]].Add(kvp.Key);
                }
                else
                {
                    List<string> aux = new List<string>();
                    aux.Add(kvp.Key);
                    ordenado[dictionary[kvp.Key]] = aux;
                }
            }

            
            int indice = 0;
            foreach (KeyValuePair<int , List<string>> kvp in ordenado.Reverse())
            {
                List<string> aux = kvp.Value;
                aux.Sort();
                foreach (string elem in aux)
                {
                    indice++;
                    topk.Add(elem);
                    if (indice >= k) return topk;
                }  
            }


            return topk;

        }

        static void Main(string[] args)
        {

            String[] words = {
            "yes", "lint", "code",
            "yes", "code", "baby",
            "you", "baby", "chrome",
            "safari", "lint", "code",
            "body", "lint", "code"
        }; //["code", "lint", "baby"]
            int k = 3;

           foreach(string elem in  TopKFrequent(words, k))
            {
                Console.Write(elem + " ");
            }

            Console.ReadLine();

        }
    }
}

