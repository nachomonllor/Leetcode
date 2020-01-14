https://leetcode.com/problems/can-place-flowers/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        public static bool CanPlaceFlowers(int[] flowerbed, int n)
        {


            if (flowerbed.Length == 1)
            {
                if (flowerbed[0] == 0)
                {
                    flowerbed[0] = 1;
                    n--;
                }
                if (n <= 0)
                {
                    return true;
                }
            }

            if (flowerbed.Length == 2)
            {
                if (flowerbed[0] == 0 && flowerbed[1] == 0)
                {
                    flowerbed[1] = 1;
                    n--;
                }
                if (n <= 0)
                {
                    return true;
                }
            }

            if (flowerbed.Length == 3)
            {
                if (flowerbed[0] == 0 && flowerbed[1] == 0)
                {
                    flowerbed[0] = 1;
                    n--;
                }

                if (n <= 0)
                {
                    return true;
                }

                if (flowerbed[1] == 0 && flowerbed[2] == 0)
                {
                    flowerbed[2] = 1;
                    n--;
                }


                if (n <= 0)
                {
                    return true;
                }
            }


            if (flowerbed[0] == 0)
            {
                if (flowerbed.Length > 1 && flowerbed[1] == 0)
                {
                    n--;
                    flowerbed[0] = 1;
                }
            }

            for (int i = 1; i + 1 < flowerbed.Length; i++)
            {
                if (flowerbed[i] == 0 && flowerbed[i - 1] == 0 && flowerbed[i + 1] == 0)
                {
                    n--;
                    flowerbed[i] = 1;
                }
            }

            if (flowerbed[flowerbed.Length - 1] == 0)
            {
                if (flowerbed.Length > 1 && flowerbed[flowerbed.Length - 2] == 0)
                {
                    flowerbed[flowerbed.Length - 1] = 1;
                    n--;
                }
            }


            return n <= 0;
        }
        static void Main(string[] args)
        {
            //int[] flowerbed = { 1, 0, 0, 0, 1 };
            //int n = 1;

            int[] flowerbed = { 0,1,0 };
            int n = 1;


            Console.WriteLine(CanPlaceFlowers(flowerbed, n));

            Console.ReadLine();
        }
    }
}
