https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static int[] TwoSum(int[] numbers, int target)
        {

            Dictionary<int, int> indices = new Dictionary<int, int>();
            for(int i =0; i<numbers.Length; i++)
            {
                indices[numbers[i]] = i;
            }


            for (int i = 0; i < numbers.Length; i++)
            {
                if(indices.ContainsKey(target - numbers[i]))
                {
                    return new int[] { i+1, indices[target - numbers[i]]+1 };
                }
               


            }
            return new int[] { };
        }


        static void Main(string[] args)
        {

            int[] numbers = { 2, 7, 11, 15 };
            int target = 9;

            int[] res = TwoSum(numbers, target);

            Console.WriteLine(res[0] + " " + res[1]);
        


            Console.ReadLine();
        }
    }
}
