https://leetcode.com/problems/generate-parentheses/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static bool isValid(string s)
        {
            string abierto = "(";
            string cerrado = ")";
            Stack<char> pila = new Stack<char>();
            bool balanceado = true;

            for (int i = 0; i < s.Length && balanceado; i++)
            {
                char actual = s[i];

                if (abierto.IndexOf(actual) > -1)
                {
                    pila.Push(actual);
                }
                else if (cerrado.IndexOf(actual) > -1)
                {
                    balanceado = (!(pila.Count == 0))
                    && cerrado.IndexOf(actual) == abierto.IndexOf(pila.Pop());
                }
            }
            return balanceado && pila.Count == 0;
        }


        public static bool nextPermutation(char[] array)
        {
            // Find non-increasing suffix
            int i = array.Length - 1;
            while (i > 0 && array[i - 1] >= array[i])
                i--;
            if (i <= 0)
                return false;

            // Find successor to pivot
            int j = array.Length - 1;
            while (array[j] <= array[i - 1])
                j--;
            char temp = array[i - 1];
            array[i - 1] = array[j];
            array[j] = temp;

            // Reverse suffix
            j = array.Length - 1;


            while (i < j)
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
                i++;
                j--;
            }
            return true;
        }

        public static IList<string> GenerateParenthesis(int n)
        {
            string s = "";

            for (int i = 0; i < n; i++)
            {
                s += "(";
            }
            for (int i = 0; i < n; i++)
            {
                s += ")";
            }
            IList<string> ans = new List<string>();

            char[] permutar = s.ToCharArray();
        //            print(permutar);
            ans.Add(new string(permutar));
            //Console.WriteLine();
            while (nextPermutation(permutar))
            {
                if (isValid(new string(permutar)))
                {
                    //print(permutar);
                    ans.Add(new string(permutar));
                    //Console.WriteLine();
                }
            }
            return ans;

        }

        static void Main(string[] args)
        {

            IList<string> res = GenerateParenthesis(3);
            foreach (string s in res)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
