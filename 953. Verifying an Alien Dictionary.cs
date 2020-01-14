https://leetcode.com/problems/verifying-an-alien-dictionary/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {


        public static bool IsAlienSorted(string[] words, string order)
        {
            order = ' ' + order;
            Dictionary<char, int> dic = new Dictionary<char, int>();
            int i;
            for ( i = 0; i < order.Length; i++)
            {
                dic[order[i]] = i;
            }

            int max_len = 0;
            for( i =0; i<words.Length; i++)
            {
                max_len = Math.Max(max_len, words[i].Length);
            }

            for( i =0; i<words.Length; i++)
            {
                words[i] = words[i] + new string(' ', max_len - words[i].Length) ;
            }

       
            for (  i = 1; i < words.Length; i++)
            {
                for (int j = 0; j < max_len; j++)
                {
                    if (dic[ words[i - 1][j]] < dic[ words[i][j]])
                    {
                        break;
                    }
                    else if(dic[words[i - 1][j]] > dic[words[i][j]])
                    {
                        return false;
                    }
                }
            }

            //if (i < words.Length) return false;

            return true;

        }



        static void Main(string[] args)
        {



            string[] words = { "hello", "leetcode" };
            string order = "hlabcdefgijkmnopqrstuvwxyz";


            //string[] words = { "word", "world", "row" };
            //string order = "worldabcefghijkmnpqstuvxyz";

            //string[] words = { "kuvp", "q" };
            //string order = "ngxlkthsjuoqcpavbfdermiywz";

            Console.WriteLine(IsAlienSorted(words, order));

            Console.ReadLine();
        }
    }
}


public static string ToGoatLatin(string S)
        {

            string vocales = "aeiou";
            vocales += vocales.ToUpper();
            string consonantes = "bcdfghjklmnpqrstvwxyz";
            consonantes += consonantes.ToUpper();

            HashSet<char> hash_vocales = new HashSet<char>(vocales.ToCharArray());
            HashSet<char> hash_consonantes = new HashSet<char>(consonantes.ToCharArray());


            string[] split = S.Split(' ');

            string addA = "a";
            StringBuilder sb = new StringBuilder();
            //List<string> lista = new List<string>();
            for (int i = 0; i < split.Length; i++)
            {
                if(hash_vocales.Contains( split[i][0]))
                {
                    //lista.Add(split[i] + "ma" + addA);
                    sb.Append(split[i]);
                    sb.Append("ma");
                    sb.Append(addA);
                    sb.Append(" ");
                }
                else if(hash_consonantes.Contains(split[i][0]))
                {
                    //lista.Add(split[i].Substring(1) + split[i][0] + "ma"+ addA);
                    sb.Append(split[i].Substring(1));
                    sb.Append(split[i][0]);
                    sb.Append("ma");
                    sb.Append(addA);
                    sb.Append(" ");
                }

                addA += "a";
            }


            //return string.Join(" ", lista);
            return sb.ToString().TrimEnd(' ');
        }

