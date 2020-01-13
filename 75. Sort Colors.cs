https://leetcode.com/problems/sort-colors/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {


        public static void SortColors(int[] nums)
        {
            //int n = nums.Length;

            // The output character array that 
            // will have sorted arr 
            int[] output = new int[nums.Length];

            // Create a count array to store  
            // count of inidividul characters  
            // and initialize count array as 0 
            int[] count = new int[4];

            for (int i = 0; i < 4; ++i)
                count[i] = 0;

            // store count of each character 
            for (int i = 0; i < nums.Length; ++i)
                ++count[nums[i]];

            // Change count[i] so that count[i]  
            // now contains actual position of  
            // this character in output array 
            for (int i = 1; i <= 3; ++i)
                count[i] += count[i - 1];

            // Build the output character array 
            // To make it stable we are operating in reverse order. 
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                output[count[nums[i]] - 1] = nums[i];
                --count[nums[i]];
            }

            // Copy the output array to arr, so 
            // that arr now contains sorted  
            // characters 
            for (int i = 0; i < nums.Length; ++i)
                nums[i] = output[i];
        }

        static void Main(string[] args)
        {
            int[] arr = { 2, 0, 2, 1, 1, 0 };

            SortColors(arr);

            for(int i =0; i<arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.ReadLine();
        }
    }
}

