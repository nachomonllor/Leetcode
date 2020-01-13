https://leetcode.com/problems/longest-valid-parentheses/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
     

        public static int LongestValidParentheses(string  s)
        {
            Stack<int[]> stack = new Stack<int[]>();
            int result = 0;

            for (int i = 0; i <= s.Length - 1; i++)
            {
                char c = s[i];
                if (c == '(')
                {
                    int[] a = { i, 0 };
                    stack.Push(a);
                }
                else
                {
                    if (stack.Count ==0 || stack.Peek()[1] == 1)
                    {
                        int[] a = { i, 1 };
                        stack.Push(a);
                    }
                    else
                    {
                        stack.Pop();
                        int currentLen = 0;
                        if (stack.Count ==0)
                        {
                            currentLen = i + 1;
                        }
                        else
                        {
                            currentLen = i - stack.Peek()[0];
                        }
                        result = Math.Max(result, currentLen);
                    }
                }
            }

            return result;
        }


        static void Main(string[] args)
        {
            string s = "((()((())))())(()))(())()())())()(()((((((())()())()()())))((((((()))())()()()()(()(()()())))()((())(((()(()(()((()())()()())))((()((()(())()())((())())))())())(())(())";
            Console.WriteLine( LongestValidParentheses(s) );
             
             
            Console.ReadLine();
        }
    }
}

