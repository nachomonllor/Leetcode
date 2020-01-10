https://leetcode.com/problems/shortest-unsorted-continuous-subarray/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        public static   int FindUnsortedSubarray(int[] nums)
        {
            int[] copia = nums.ToArray();

            Array.Sort(copia);

            int ini = -1;

            for (int i = 0; i < copia.Length; i++)
            {
                if (nums[i] != copia[i])
                {
                    ini = i;
                    break;
                }
            }

            int fin = -1;
            for(int i = copia.Length-1; i>=0; i--)
            {
                if(copia[i] != nums[i])
                {
                    fin = i;
                    break;
                }
            }

            if (fin - ini == 0) return 0;

            return fin - ini + 1;
        }

        static void Main(string[] args)
        {
            int[] input = { 2, 6, 4, 8, 10, 9, 15 };

            Console.WriteLine(FindUnsortedSubarray(input));

            Console.ReadLine();
        }
    }
}
