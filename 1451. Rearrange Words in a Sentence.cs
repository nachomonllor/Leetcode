using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication39
{
    class Program
    {


        


        public static string ArrangeWords(string text)
        {

            string[] spl = text.Split(' ');
            SortedDictionary<int, List<string>> dic = new SortedDictionary<int, List<string>>();

            for (int i = 0; i < spl.Length; i++)
            {

                if (dic.ContainsKey(spl[i].Length))
                {
                    dic[spl[i].Length].Add(spl[i]);
                }
                else
                {
                    dic[spl[i].Length] = new List<string>();
                    dic[spl[i].Length].Add(spl[i]);
                }

            }

            //var items = from pair in dic
            //            orderby pair.Key ascending
            //            select pair;

            StringBuilder concat = new StringBuilder();
            foreach (KeyValuePair<int, List<string>> kvp in dic)
            {
                foreach (string item in kvp.Value)
                {
                    //Console.Write(item + " ");
                    concat.Append(item + " ");
                }
                //Console.WriteLine();
            }

            string res = concat.ToString().Trim();

            if (text.Length == 1)
            {
                return char.ToUpper(res[0]).ToString();
            }

            return char.ToUpper(res[0]) + res.Substring(1).ToLower();

           // return "";
        }


        static void Main(string[] args)
        {

            string text = "Keep calm and code on";
            //string text = "Leetcode is cool";
            Console.WriteLine( ArrangeWords(text));


            

            Console.ReadLine();
        }
    }
}
