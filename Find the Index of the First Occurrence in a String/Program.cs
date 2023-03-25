using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_Index_of_the_First_Occurrence_in_a_String
{
    internal class Program
    {
        public static int StrStr(string haystack, string needle)
        {
            int len_subs = needle.Length;

            if (len_subs > haystack.Length) return -1;


            string subs = haystack.Substring(0, len_subs);
            if (subs == needle) return 0;

            for (int i = 0; i  + len_subs < haystack.Length; i++)
            {
                subs = subs.Substring(1) + haystack[i+len_subs];
                if (subs == needle) return i + 1;
            }

            return -1;
        }
        static void Main(string[] args)
        {

            //string haystack = "sadbutsad";
            //string needle = "sad";

            //string haystack = "leetcode", needle = "leeto";

            //string haystack = "hello";
            //string needle = "ll";

            string haystack = "aaa";
            string needle = "aaaa";

            Console.WriteLine(StrStr(haystack, needle));

            Console.ReadLine();
        }
    }
}
