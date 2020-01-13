https://leetcode.com/problems/reverse-vowels-of-a-string/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        public static string ReverseVowels(string s)
        {
            char[] ch = s.ToCharArray();

            int i = 0, j = s.Length - 1;
            

            string vocales = "AEIOUaeiou";
            while (i < j)
            {
                while (i < j && !vocales.Contains(ch[i]))
                {
                    i++;
                }
                while (j > i && !vocales.Contains(ch[j]))
                {
                    j--;
                }

                char temp = ch[i];
                ch[i] = ch[j];
                ch[j] = temp;
                i++;
                j--;

            }


            return new string(ch);
        }


        static void Main(string[] args)
        {

            Console.WriteLine(ReverseVowels("leetcode"));
            Console.ReadLine();
        }
    }
}
