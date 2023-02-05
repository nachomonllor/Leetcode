using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        public static int[] SeparateDigits(int[] nums)
        {
            return (string.Join("", nums.Select(n => n.ToString()).ToList())).Select(c => int.Parse(c.ToString())).ToArray();
        }

        static void Main(string[] args)
        {

            int[] nums = { 13, 25, 83, 77 };
            //Output: [1,3,2,5,8,3,7,7]

            int[] r = SeparateDigits(nums);

            foreach(int dig in r)
            {
                Console.Write(dig + " ");
            }

            Console.ReadLine();
        }
    }
}
