using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2154KeepMultiplyingFoundValuesByTwo
{
    class Program
    {
        public static int FindFinalValue(int[] nums, int original)
        {
            int o = original;

            HashSet<int> hash = new HashSet<int>(nums);

            while (hash.Contains(o))
            {
                o = o * 2;
            }

            return o;

        }



        static void Main(string[] args)
        {


            //int[] nums = { 5, 3, 6, 1, 12 };
            //int original = 3;
            //Output: 24


            int[] nums = { 161, 28, 640, 264, 81, 561, 320, 2, 61, 244, 183, 108, 773, 61, 976, 122, 988, 2, 370, 392, 488, 375, 349, 432, 713, 563 };
            int original = 61;



            Console.WriteLine(FindFinalValue(nums, original));


            Console.ReadLine();
        }
    }
}
