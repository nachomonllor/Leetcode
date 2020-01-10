https://leetcode.com/problems/valid-palindrome-ii/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {

     

        //public static bool ValidPalindrome(string s)
        //{  
        //    for(int i =0; i<s.Length; i++)
        //    {
        //        string subs = s;
        //        subs = subs.Remove(i, 1);

        //        char[] rev = subs.ToCharArray();
        //        string a = new string(rev);
        //        Array.Reverse(rev);
        //        string b = new string(rev);

        //        if (a == b) return true;

        //    }

        //    return false;
        //}



        public static bool ValidPalindrome(string s)
        {

            int i = 0, j = s.Length - 1;

            int distintos = 0;
            while (i < j)
            {
                if (s[i] != s[j])
                {
                    distintos++;
                    if (s[i + 1] == s[j]) i++;
                    else if (s[i] == s[j - 1]) j--;
                    else
                    {
                        distintos++;
                    }
                }

                //if (distintos > 1) return false;
                i++;
                j--;
            }

            int distintos2 = 0;

            i = 0;
            j = s.Length - 1;

            while (i < j)
            {
                if (s[i] != s[j])
                {
                    distintos2++;
                    if (s[i] == s[j-1]) j--;
                    else if (s[i+1] == s[j ]) i++;
                    else
                    {
                        distintos2++;
                    }
                }

                //if (distintos2 > 1) return false;
                i++;
                j--;
            }

            if (distintos <= 1 || distintos2 <= 1) return true;

            return false;
        }

        static void Main(string[] args)
        {

            Console.WriteLine(ValidPalindrome("abc"));
            Console.WriteLine(ValidPalindrome("abca"));
            Console.WriteLine(ValidPalindrome("deeee"));
            Console.WriteLine(ValidPalindrome("abca"));
            Console.WriteLine(ValidPalindrome("eedede"));
            Console.WriteLine(ValidPalindrome("aguokepatgbnvfqmgmlcupuufxoohdfpgjdmysgvhmvffcnqxjjxqncffvmhvgsymdjgpfdhooxfuupuculmgmqfvnbgtapekouga"));
            Console.WriteLine(ValidPalindrome("qmgmlcupuuuupuculmgmq"));
            Console.ReadLine();
        }
    }
}
