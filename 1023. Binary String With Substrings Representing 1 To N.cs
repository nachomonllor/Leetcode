https://leetcode.com/problems/binary-string-with-substrings-representing-1-to-n/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {



     

        public static bool QueryString(string S, int N)
        {

            for (int i = 1; i <= N; i++)
            {
                //string bin = StringToBinary(i.ToString());
                string bin = Convert.ToString(Convert.ToInt32(i.ToString(), 10), 2);

                if (!S.Contains(bin))
                {
                    return false;
                }
            }
            return true;
        }



        static void Main(string[] args)
        {

           string s = "0110";
           int n = 3;

           Console.WriteLine(QueryString(s, n));

            Console.ReadLine();

        }
    }
}

