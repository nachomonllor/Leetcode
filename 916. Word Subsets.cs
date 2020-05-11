using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication29
{
    class Program
    {


        public static IList<string> WordSubsets(string[] A, string[] B)
        {

            int[] maxFrecB = new int[26];

            foreach (string item in B)
            {
                int[] frec = new int[26];
                for (int i = 0; i < item.Length; i++)
                {
                    frec[item[i] - 'a']++;
                }

                for (int i = 0; i < item.Length; i++)
                {
                    maxFrecB[item[i] - 'a'] = Math.Max(maxFrecB[item[i] - 'a'], frec[item[i] - 'a']);
                }

            }


            IList<string> res = new List<string>();
            for (int i = 0; i < A.Length; i++)
            {
                int[] frec = contadorFrecuencias(A[i]);
                //verifico que esa palabra forma parte del output
                bool va = true;
                for (int j = 0; j < 26; j++)
                {
                    if (frec[j] < maxFrecB[j])
                    {
                        va = false;
                        break;
                    }
                }

                if (va)
                {
                    res.Add(A[i]);
                }
            }

            return res;

        }

        static int[] contadorFrecuencias(string p)
        {
            int[] frec = new int[26];

            for (int i = 0; i < p.Length; i++)
            {
                frec[p[i] - 'a']++;
            }
            return frec;

        }

        static void Main(string[] args)
        {

            string[] A = {"amazon","apple","facebook","google","leetcode"};
            string[] B = {"lo","eo"};

            //Output: ["google","leetcode"]


            IList<string> lista = WordSubsets(A, B);

            foreach (string item in lista)
            {
                Console.WriteLine(item);
            }



            Console.ReadLine();

        }


    }
}
