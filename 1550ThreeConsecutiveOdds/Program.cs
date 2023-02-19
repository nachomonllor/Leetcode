using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1550ThreeConsecutiveOdds
{
    class Program
    {

        public static  bool ThreeConsecutiveOdds(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int contOdd = 0;
                for (int odd = i; odd < arr.Length && odd < i + 3; odd++)
                {
                    if (arr[odd] % 2 == 0)
                    {
                        break;
                    }
                    else
                    {
                        contOdd++;
                    }
                }
                if (contOdd== 3) return true;
            }
            return false;

        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 34, 3, 4, 5, 7, 23, 12 };
            // Output: true
            // Explanation: [5,7,23] are three consecutive odds.

            Console.WriteLine(ThreeConsecutiveOdds(arr));


            //int[] arr = { 2, 6, 4, 1 };
            ////Output: false
            ////Explanation: There are no three consecutive odds.

            //Console.WriteLine(ThreeConsecutiveOdds(arr));



            Console.ReadLine();
        }
    }
}
