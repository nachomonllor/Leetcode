using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2544AlternatingDigitSum
{
    class Program
    {
        public static int AlternateDigitSum(int n)
        {
            string s = n+"";
            int signo = 1;
            int sum = 0;    
            for(int i = 0; i < s.Length; i++)
            {
                sum += (s[i] - '0') * signo;
                signo = -signo;
            }

            return sum;
        }


        static void Main(string[] args)
        {
            int n = 521;
            //Output: 4

            Console.WriteLine(AlternateDigitSum(n));

            Console.ReadLine(); 
        }
    }
}
