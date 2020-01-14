https://leetcode.com/problems/reverse-string-ii/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

       
        static string InvertirString(string s)
        {
            char[] ch = s.ToCharArray();
            int i = 0, j = ch.Length - 1;

            while(i<j)
            {
                char temp = ch[i];
                ch[i] = ch[j];
                ch[j] = temp;
                i++;
                j--;
            }
            return new string(ch);
        }

        public static string ReverseStr(string s, int k)
        {
            if (k > s.Length) return InvertirString( s);

            string ans = "";
            bool flag = true;
            int i;
            for( i=0; i+k<s.Length; i+=k)
            {
                if (flag)
                {
                    ans += InvertirString(s.Substring(i, k));
                    flag = false;
                }
                else  if(!flag)
                {
                    ans += s.Substring(i, k);
                    flag = true;
                }
            }
            if (i < s.Length && !flag) ans += s.Substring(i);
            else if (i < s.Length && flag) ans += InvertirString( s.Substring(i));

            return ans;
        }

        static void Main(string[] args)
        {
            //string s = "hyzqyljrnigxvdtneasepfahmtyhlohwxmkqcdfehybknvdmfrfvtbsovjbdhevlfxpdaovjgunjqlimjkfnqcqnajmebeddqsgl";
            //int k = 39;

            //string s = "abcdefg"; //"bacdfeg"
            //int k = 2;
            string s = "12345678912345678912";
            int k = 3;

           Console.WriteLine(  ReverseStr(s,k));


            Console.ReadLine();
        }
    }
}
