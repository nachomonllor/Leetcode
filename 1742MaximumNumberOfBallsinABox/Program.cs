using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1742MaximumNumberOfBallsinABox
{
    class Program
    {

        public static int CountBalls(int lowLimit, int highLimit)
        {
            int[] dic = new int[100];

            for (int i = lowLimit; i <= highLimit; i++)
            {
                int suma = 0;
                int copia = i;
                while (copia > 0)
                {
                    suma += copia % 10;
                    copia /=10;
                }
                dic[suma]++;
            }

            int max_indice_frec = 0;

            for (int i = 0; i < 100; i++)
            {
                if (dic[i] > dic[max_indice_frec])
                {
                    max_indice_frec = i;
                }

            }
            return dic[max_indice_frec];
        }


        static void Main(string[] args)
        {
            // int lowLimit = 5, highLimit = 15;
            //int lowLimit = 1, highLimit = 10;
            int lowLimit = 19, highLimit = 28;

            Console.WriteLine(CountBalls(lowLimit, highLimit));

            Console.ReadLine();
        }
    }
}
