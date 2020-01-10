https://leetcode.com/problems/sum-of-square-numbers/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {

        //public bool ValidPalindrome(string s)
        //{

        //}

        //static bool EsCuadrado(int n)
        //{
        //    int sqr = (int)Math.Sqrt(n);
        //    return sqr * sqr == n;
        //}

        //public static bool JudgeSquareSum(int c)
        //{

        //    for (int i = 0; i<= c ; i++)
        //    {
        //       // Console.WriteLine(i + " " + (c - i));
        //        //if (i * i + (c - i) * (c - i) == c) return true;
        //        if (EsCuadrado(i) && EsCuadrado(c - i)) return true;
        //    }
        //    return false;
        //}
        //public static bool JudgeSquareSum(int c)
        //{

        //    for (long i = 0; i * i <= c; i++)
        //    {
        //        for (long j = i+1; j * j <= c; j++)
        //        {
        //            //Console.WriteLine(i + " " + j);
        //            if (i * i + j * j == c) return true;
        //        }
        //    }
        //    return false;
        //}

        // A function to print all prime  
        // factors of a given number n 
        public static Dictionary<int, int> primeFactors(int n)
        {
            //List<int> primos = new List<int>();
            Dictionary<int, int> diccio = new Dictionary<int, int>();
            // Print the number of 2s that divide n 
            while (n % 2 == 0)
            {
                //Console.Write(2 + " ");
                //primos.Add(2);
                if (diccio.ContainsKey(2))
                {
                    diccio[2]++;
                }
                else
                {
                    diccio[2] = 1;
                }


                n /= 2;
            }

            // n must be odd at this point. So we can 
            // skip one element (Note i = i +2) 
            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                // While i divides n, print i and divide n 
                while (n % i == 0)
                {
                    // Console.Write(i + " ");
                    //primos.Add(i);
                    if(diccio.ContainsKey(i))
                    {
                        diccio[i]++;
                    }else
                    {
                        diccio[i] = 1;
                    }

                    n /= i;
                }
            }

            // This condition is to handle the case whien 
            // n is a prime number greater than 2 
            if (n > 2)
            {
                // Console.Write(n);
                if (diccio.ContainsKey(n))
                {
                    diccio[n]++;
                }
                else
                {
                    diccio[n] = 1;
                }
            }
            return diccio;
        }

        static bool es4k3(int n)
        {
            if (n == 3) return true;

            n -= 3;
            if (n == 3) return true;

            if (n % 4 == 0) return true;
            return false;
        }

        public static bool JudgeSquareSum(int c)
        {
            if (c == 0) return false;
            foreach(KeyValuePair<int,int> kvp in primeFactors(c))
            {
                if (es4k3(kvp.Key))
                {
                    if (kvp.Value % 2 != 0) return false;
                }
            }
            return true;
        }


        // Driver Code 
        public static void Main()
        {
            //int n = 315;
            //foreach (KeyValuePair<int,int> kvp in primeFactors(n))
            //{
            //    //Console.Write(elem + " ");
            //    Console.WriteLine(kvp.Key + " " + kvp.Value);
            //}

            Console.WriteLine(JudgeSquareSum(0));

            //Console.WriteLine(es4k3(41));

            Console.ReadLine();
        }

        //static void Main(string[] args)
        //{

        //    //Console.WriteLine(JudgeSquareSum(2147482647));
        //    Console.WriteLine(JudgeSquareSum(999999999));
        //    Console.ReadLine();
        //}

    }
}
