https://leetcode.com/problems/binary-gap/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        public static  int BinaryGap(int N)
        {
            string binary = Convert.ToString(N, 2);


            int ceros = 0;
            int unos = 0;
            int max_ceros = 0;
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '0')
                {
                    ceros++;

                }
                else
                {
                    unos++;
                    max_ceros = Math.Max(max_ceros, ceros);
                    ceros = 0;
                }
            }

            if (unos <= 1) return 0;

            return max_ceros + 1;

        }


        static void Main(string[] args)
        {


            Console.WriteLine(BinaryGap(8));

            Console.ReadLine();
        }
    }
}

