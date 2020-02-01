using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        public static  int Tribonacci(int n)
        {

            List<int> trib = new List<int>();
            trib.Add(0);
            trib.Add(1);
            trib.Add(1);

            for (int i = 3; i <= n; i++)
            {
                trib.Add(trib[i-1] + trib[i - 2] + trib[i - 3]);
            }
            return trib[n];
        }

        static void Main(string[] args)
        {

            Console.WriteLine(Tribonacci(4));
            Console.ReadLine();

        }
    }
}
