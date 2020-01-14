https://leetcode.com/problems/most-common-word/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {



        public static string MostCommonWord(string paragraph, string[] banned)
        {
            string[] items = paragraph.ToLower().Trim().Split(new char[] {' ', '!', '?', '\'', ',', ';', '.' } );

            //!? ',;.

            for(int i =0; i<items.Length; i++)
            {
                items[i] = items[i].Trim(). TrimEnd(new char[] { '!', '?', '\'', ',', ';', '.' });
                items[i] = items[i].Trim(). TrimStart(new char[] { '!', '?', '\'', ',', ';', '.' });
            }

            for (int i = 0; i < banned.Length; i++)
            {
                banned[i] = banned[i].ToLower();
               
            }
            HashSet<string> hash_baneados = new HashSet<string>(banned);

            Dictionary<string, int> dic = new Dictionary<string, int>();

            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Length > 0)
                {
                    if (dic.ContainsKey(items[i])) dic[items[i]]++;
                    else dic[items[i]] = 1;
                }
            }

            var ordenado = from pair in dic 
                        orderby pair.Value descending 
                        select pair;


            foreach(var item in ordenado)
            {
                if( !hash_baneados.Contains( item.Key))
                {
                    return item.Key;
                }
            }
            return "";

          


        }


        static void Main(string[] args)
        {

            //string paragraph = "Bob hit a ball, the hit BALL flew far after it was hit.";
            //string[] banned = { "hit" };

            //string paragraph = "a, a, a, a, b,b,b,c, c";
            //string[] banned = { "a" };

            string paragraph = "Bob. hIt, baLl";
            string[] banned = { "bob", "hit" };

            Console.WriteLine(MostCommonWord(  paragraph , banned  ));

            Console.ReadLine();

        }
    }
}
