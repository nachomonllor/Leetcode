https://leetcode.com/problems/goat-latin/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {


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
            List<string> lista = new List<string>();
            for (int i = 0; i < split.Length; i++)
            {
                if(hash_vocales.Contains( split[i][0]))
                {
                    lista.Add(split[i] + "ma" + addA);
                }
                else if(hash_consonantes.Contains(split[i][0]))
                {
                    lista.Add(split[i].Substring(1) + split[i][0] + "ma"+ addA);
                }

                addA += "a";
            }


            return string.Join(" ", lista);
        }


        static void Main(string[] args)
        {

            string Input = "I speak Goat Latin";
            Console.WriteLine(ToGoatLatin(Input));


            Console.ReadLine();
        }
    }
}

