https://leetcode.com/problems/reverse-only-letters/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {


        public static  string ReverseOnlyLetters(string S)
        {
            int i = 0, j = S.Length - 1;

            char[] ch = S.ToCharArray();

            while(i < j)
            {
                while (i<j && !char.IsLetter(ch[i])) i++;
                while (i<j && !char.IsLetter(ch[j])) j--;
                
                if(i< j && char.IsLetter(ch[i]) && char.IsLetter(ch[j]))
                {
                    char temp = ch[i];
                    ch[i] = ch[j];
                    ch[j] = temp;
                    i++;
                    j--;
                }
            }

            return new string(ch);

        }


        static void Main(string[] args)
        {

            //string Input = "a-bC-dEf-ghIj";
            // string input = "7_28]";
            string input = "?6C40E";
            //"?6C40E"
            //"?6E40C"
            Console.WriteLine(ReverseOnlyLetters(input));



            Console.ReadLine();
        }
    }
}
