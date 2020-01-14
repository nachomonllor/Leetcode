https://leetcode.com/problems/uncommon-words-from-two-sentences/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        public static string[] UncommonFromSentences(string A, string B)
        {

            string[] wa = A.Split(' ');
            string[] wb = B.Split(' ');

            Dictionary<string, int> da = new Dictionary<string, int>();
            foreach(string elem in wa)
            {
                if(da.ContainsKey(elem)) da[elem]++;
                else da[elem] = 1;
            }

            Dictionary<string, int> db = new Dictionary<string, int>();
            foreach(string elem in wb)
            {
                if(db.ContainsKey(elem)) db[elem]++;
                else db[elem] = 1;
            }

            List<string> PocoComunes = new List<string>();
            foreach(KeyValuePair<string, int> kvp in da)
            {
                if(kvp.Value == 1 && !db.ContainsKey(kvp.Key))
                {
                    PocoComunes.Add(kvp.Key);
                }
            }

            foreach (KeyValuePair<string, int> kvp in db)
            {
                if (kvp.Value == 1 && !da.ContainsKey(kvp.Key))
                {
                    PocoComunes.Add(kvp.Key);
                }
            }

            return PocoComunes.ToArray();
        }

        static void Main(string[] args)
        {

            string A = "this apple is sweet";
            string B = "this apple is sour";
            //Output: ["sweet", "sour"]

            foreach (string elem in UncommonFromSentences(A, B))
            {
                Console.Write(elem + " ");
            }

            Console.ReadLine();
        }
    }
}
