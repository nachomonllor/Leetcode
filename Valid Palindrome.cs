using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static bool EsPalindromo(string s)
        {
            int n = s.Length;
            int i = 0, j = s.Length - 1;
            while (i < j)
            {
                while (i < n && !ChAceptado(s[i])) i++;
                while (j > 0 && !ChAceptado(s[j])) j--;
                if (i < n && j > 0 && char.ToUpper(s[i]) != char.ToUpper(s[j]))
                {
                    return false;
                }
                else
                {
                    i++;
                    j--;
                }
            }
            return true;
        }
        static bool ChAceptado(char c)
        {
            if (char.IsLetter(c) || char.IsNumber(c)) return true;
            return false;
        }

        static void Main(string[] args)
        {
        }
    }
}
