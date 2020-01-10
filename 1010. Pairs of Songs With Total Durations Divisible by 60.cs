using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public static int NumPairsDivisibleBy60(int[] time)
        {

            //int ans = 0;

            int[] multiplos = { 60, 120, 180, 240, 300, 360, 420, 480,540,600,660,720,780,840,900,960 };

            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < time.Length; i++)
            {
                if (dic.ContainsKey(time[i]))
                {
                    dic[time[i]]++;
                }
                else
                {
                    dic[time[i]] = 1;
                }
            }
            //int ans = 0;
            Dictionary<string, int> pares = new Dictionary<string, int>();
            foreach (KeyValuePair<int, int> kvp in dic)
            {
                for (int j = 0; j < multiplos.Length; j++)
                {
                    if (dic.ContainsKey(multiplos[j] - kvp.Key))
                    {
                       int n = kvp.Value;
                       if (multiplos[j] - kvp.Key == kvp.Key)
                       {

                         //  ans += n * (n - 1) / 2;
                           int x = kvp.Key;
                          // int max = Math.Max(  multiplos[j] - kvp.Key , kvp.Key);
                           pares[x + " " + x] = n * (n - 1) / 2;
                       }
                       else
                       {
                           int min = Math.Min(multiplos[j] - kvp.Key, kvp.Key);
                           int max = Math.Max(multiplos[j] - kvp.Key, kvp.Key);

                           pares[min + " " + max] = dic[min] * dic[max];
                           //ans += n * dic[multiplos[j] - kvp.Key];
                       }
                    }
                }
                

            }

            int sum = 0;
            foreach (KeyValuePair<string, int> kvp in pares)
            {
                sum += kvp.Value;
            }


            return sum;
        }

        static void Main(string[] args)
        {
            //int[] Input = { 30, 20, 150, 100, 40 };
            //int[] Input = {60,60,60 };
            //int[] Input = { 15, 63, 451, 213, 37, 209, 343, 319 };

            int[] Input = { 269, 230, 318, 468, 171, 158, 350, 60, 287, 27, 11, 384, 332, 267, 412, 478, 280, 303, 242, 378, 129, 131, 164, 467, 345, 146, 264, 332, 276, 479, 284, 433, 117, 197, 430, 203, 100, 280, 145, 287, 91, 157, 5, 475, 288, 146, 370, 199, 81, 428, 278, 2, 400, 23, 470, 242, 411, 470, 330, 144, 189, 204, 62, 318, 475, 24, 457, 83, 204, 322, 250, 478, 186, 467, 350, 171, 119, 245, 399, 112, 252, 201, 324, 317, 293, 44, 295, 14, 379, 382, 137, 280, 265, 78, 38, 323, 347, 499, 238, 110, 18, 224, 473, 289, 198, 106, 256, 279, 275, 349, 210, 498, 201, 175, 472, 461, 116, 144, 9, 221, 473 };

            Console.WriteLine(NumPairsDivisibleBy60(Input));
            //  Console.WriteLine(Input.Length);
            //  Console.WriteLine(Input.Distinct().ToArray().Length);

            Console.ReadLine();
        }
    }
}
