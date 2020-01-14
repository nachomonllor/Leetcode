https://leetcode.com/problems/maximum-swap/description/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp74
{
    class Program
    {

        public static int MaximumSwap(int num)
        {
            char[] ch = num.ToString().ToCharArray();

            int max = num;
            for(int i =0; i<ch.Length-1; i++)
            {
                for(int j=i+1; j<ch.Length; j++)
                {
                    char temp = ch[i];
                    ch[i] = ch[j];
                    ch[j] = temp;
                    max = Math.Max(max, int.Parse(new string(ch)));
                    temp = ch[j];
                    ch[j] = ch[i];
                    ch[i] = temp;
                }
            }
            return max;
        }

        static void Main(string[] args)
        {

            Console.WriteLine( MaximumSwap(1));

            Console.ReadLine();
        }
    }
}
