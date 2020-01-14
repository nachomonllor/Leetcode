https://leetcode.com/problems/backspace-string-compare/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static string Limpiar(string x)
        {
            Stack<char> st = new Stack<char>();
            int i;
            for(i =0; i<x.Length; i++)
            {
                if (x[i] == '#')
                {
                    if(st.Count > 0)
                    {
                        st.Pop();
                    }
                }
                else
                {
                    st.Push(x[i]);
                }
            }

            return new string(st.ToArray()); 
            
        }



        public static bool BackspaceCompare(string S, string T)
        {
            return Limpiar(S) == Limpiar(T);
        }

        static void Main(string[] args)
        {
            string S = "a##c";

            Console.WriteLine(Limpiar(S));

            Console.ReadLine();
        }
    }
}
