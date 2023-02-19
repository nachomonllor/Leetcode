using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _1619_Mean_of_Array_After_Removing_Some_Elements
{
    class Program
    {

        /*
        Given an integer array arr, return the mean of the remaining integers after removing the smallest 5% and the largest 5% of the elements.
        Answers within 10-5 of the actual answer will be considered accepted.
        Example 1:
        Input: arr = [1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3]
        Output: 2.00000
        Explanation: After erasing the minimum and the maximum values of this array, all elements are equal to 2, so the mean is 2.
        */


        //public static  double Get5(int len)
        //{
        //    return len * 0.05;
        //}

        public static  double TrimMean(int[] arr)
        {
            Array.Sort(arr);

            double five_percent_size = arr.Length *0.05;
            double suma = 0.0;
            double size = 0.0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i >= five_percent_size && arr.Length - i > five_percent_size)
                {
                    suma += arr[i];
                    size++;
                }
            }

            return suma / size;
        }


        static void Main(string[] args)
        {

            //int[] arr = { 6, 2, 7, 5, 1, 2, 0, 3, 10, 2, 5, 0, 5, 5, 0, 8, 7, 6, 8, 0 };
            ////Output: 4.00000

            //Array.Sort(arr);    

            //foreach(int item in arr)
            //{
            //    Console.Write(item + " ");
            //}


            int[] arr = { 6, 0, 7, 0, 7, 5, 7, 8, 3, 4, 0, 7, 8, 1, 6, 8, 1, 1, 2, 4, 8, 1, 9, 5, 4, 3, 8, 5, 10, 8, 6, 6, 1, 0, 6, 10, 8, 2, 3, 4 };
            //Output: 4.77778
            //Array.Sort(arr);

            //foreach (int item in arr)
            //{
            //    Console.Write(item + " ");
            //}
            Console.WriteLine(TrimMean(arr));


            Console.ReadLine();
        }
    }
}
