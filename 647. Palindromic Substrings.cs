https://leetcode.com/problems/palindromic-substrings/description/

-----BASADO EN EL ALGORITMO “LONGEST PALINDROMIC SUBSTRING” (con programación dinámica)---------
https://www.geeksforgeeks.org/longest-palindrome-substring-set-1/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp80
{
    class Program
    {

        public int CountSubstrings(string s)
        {
            
                int n = s.Length;   // get length of input string

            // table[i][j] will be false if substring str[i..j]
            // is not palindrome.
            // Else table[i][j] will be true
            bool[,] table = new bool[n, n];

            // All substrings of length 1 are palindromes
            int maxLength = 1;
            for (int i = 0; i < n; ++i)
                table[i, i] = true;

            // check for sub-string of length 2.
            int start = 0;
            for (int i = 0; i < n - 1; ++i)
            {
                if (s[i] == s[i + 1])
                {
                    table[i, i + 1] = true;
                    start = i;
                    maxLength = 2;
                }
            }

            // Check for lengths greater than 2. k is length
            // of substring
            for (int k = 3; k <= n; ++k)
            {

                // Fix the starting index
                for (int i = 0; i < n - k + 1; ++i)
                {
                    // Get the ending index of substring from
                    // starting index i and length k
                    int j = i + k - 1;

                    // checking for sub-string from ith index to
                    // jth index iff str.charAt(i+1) to 
                    // str.charAt(j-1) is a palindrome
                    if (table[i + 1, j - 1] && s[i] ==
                                              s[j])
                    {
                        table[i, j] = true;

                        if (k > maxLength)
                        {
                            start = i;
                            maxLength = k;
                        }
                    }
                }
            }
            //System.out.print("Longest palindrome substring is; ");
            //printSubStr(str, start, start + maxLength - 1);

            //return maxLength; // return length of LPS
            int ans = 0;

            for(int i =0; i<n; i++)
            {
                for(int j =0; j<n; j++)
                {
                    if (table[i, j])
                    {
                        ans++;
                    }
                }
            }
            return ans;
        }


        static void Main(string[] args)
        {
        }
    }
}
