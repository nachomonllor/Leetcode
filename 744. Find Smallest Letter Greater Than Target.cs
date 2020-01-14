https://leetcode.com/problems/find-smallest-letter-greater-than-target/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {



        public static char NextGreatestLetter(char[] letters, char target)
        {
            //if (letters.Length == 0 || target == 0) return ' ';
            HashSet<char> hashLetters = new HashSet<char>();
            for (int i = 0; i < letters.Length; i++)
            {
                hashLetters.Add(letters[i]);
            }

            char[] unicos = hashLetters.ToArray();

            if (target < unicos[0] || target >= unicos[unicos.Length - 1]) return unicos[0];
            if (target == unicos[0] && unicos.Length > 1) return unicos[1];

            for (int i = 0; i < unicos.Length; i++)
            {
                if (i + 1 < unicos.Length && target >= unicos[i] && target <= unicos[i + 1])
                {
                    if (i + 1 < unicos.Length) return unicos[i + 1];
                    else return unicos[0];
                }
            }
            return char.MinValue;
        }

        static void Main(string[] args)
        {


            //char[] ch = { 'c', 'f', 'j' };
            //char caracter = 'c';

            //char[] ch = { 'c', 'f', 'j' };
            //char caracter = 'g';

            char[] ch = { 'c', 'f', 'j' };
            char caracter = 'j';


            Console.WriteLine( NextGreatestLetter(ch, caracter));

            Console.ReadLine();
        }
    }
}
