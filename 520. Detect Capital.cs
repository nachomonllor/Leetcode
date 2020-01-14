https://leetcode.com/problems/detect-capital/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        public static bool DetectCapitalUse(string word)
        {

            string upper = word.ToUpper();
            string lower = word.ToLower();
            string primeraMayuscula = char.ToUpper(word[0]) + word.Substring(1).ToLower();

            return upper == word || lower == word || primeraMayuscula == word;

        }

        static void Main(string[] args)
        {

            Console.ReadLine();
        }
    }
}
