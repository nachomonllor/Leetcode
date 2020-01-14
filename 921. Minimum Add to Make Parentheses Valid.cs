https://leetcode.com/problems/minimum-add-to-make-parentheses-valid/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static int MinAddToMakeValid(string S)
        {
            Stack<char> stack =
                new Stack<char>();

            int cont = 0;
            for(int i =0; i<S.Length; i++)
            {
                if(S[i] == '(')
                {
                    stack.Push(S[i]);
                }
                else if(S[i] == ')')
                {
                    if(stack.Count > 0)
                    {
                        stack.Pop();
                    }
                    else
                    {
                        cont++;
                    }
                }

            }
            return cont + stack.Count;
        }

        static void Main(string[] args)
        {
            string input = "()))((";



            Console.ReadLine();
        }
    }
}
