using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        public static int LengthOfLastWord(string s)
        {

            if (s.Length == 0) return 0;
            int j = s.Length - 1;

            //busco la primer letra desde la derecha
            while (j >= 0 && s[j] == ' ')
            {
                j--;
            }

            //ahora busco el primer espacio
            int i = j;
            int t = 0;
            while (i >= 0 && s[i] != ' ')
            {
                i--;
                t++;
            }
            return t;
        }

        static void Main(string[] args)
        {
           // string s = "Hello World";
            //string s = " a";
            //string s = "";
            //string s = "         ";
            //string s = "day";
            //string s = " ";
            string s = "a ";

            int n = LengthOfLastWord(s);
            Console.WriteLine(n);

            Console.ReadLine();

        }

 
    }
}
