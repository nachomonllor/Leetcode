https://leetcode.com/problems/find-words-that-can-be-formed-by-characters/submissions/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static int[] obtenerDiccionario(string p)
        {
            int[] hash = new int[26];
            for (int i = 0; i < p.Length; i++)
            {
                hash[p[i] - 'a']++;
            }
            return hash;
        }

        public static int CountCharacters(string[] words, string chars)
        {
            //HashSet<char> hash = new HashSet<char>(chars.ToCharArray());
            int[] hash_chars = obtenerDiccionario(chars);
            int sum = 0;
            for (int i = 0; i < words.Length; i++)
            {
                int[] dic_aux = obtenerDiccionario(words[i]);
                bool flag = true;
                for (int j = 0; j < dic_aux.Length; j++)
                {
                    if (dic_aux[j] > hash_chars[j])
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    sum += words[i].Length;
                }
            }
            return sum;
        }



        static void Main(string[] args)
        {
            string[] words = {"cat","bt","hat","tree"};
            string chars = "atach";
            Console.WriteLine( CountCharacters(words, chars));

            Console.ReadLine();
        }
    }
}
