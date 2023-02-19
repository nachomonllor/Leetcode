using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _215_Kth_Largest_Element_in_an_Array
{
    class Program
    {
        public static int FindKthLargest(int[] nums, int k)
        {
            int max = nums.Max();
            int min = nums.Min();
            int kth = 0;

            if (max > 0)
            {
                int numero;
                int[] countPos = new int[max + 1];

                for (int index = 0; index < nums.Length; index++)
                {
                    if (nums[index] >= 0)
                    {
                        countPos[nums[index]]++;
                    }
                }

                numero = max;

                while (numero >= 0)
                {
                    while (numero >= 0 && countPos[numero] > 0)
                    {
                        int resto = k-kth;

                        if (countPos[numero]-resto > 0)
                        {
                            countPos[numero]-=resto;
                            kth+=resto;

                        }
                        else
                        {
                            kth += countPos[numero];
                            countPos[numero] = 0;

                        }

                        if (kth == k) return numero;
                    }
                    numero--;
                }

            }

            if (min < 0)
            {
                int numero;
                int[] countNeg = new int[(-min) + 1];

                for (int index = 0; index < nums.Length; index++)
                {
                    if (nums[index] < 0)
                    {
                        countNeg[-nums[index]]++;
                    }
                }

                numero = -1; //numero es positivo

                while (numero >= min)
                {
                    while (numero < 0 && countNeg[-numero] > 0)
                    {
                        int resto = k-kth;

                        if (countNeg[-numero] - resto > 0)
                        {
                            countNeg[-numero] -= resto;
                            kth += resto;

                        }
                        else
                        {
                            kth += countNeg[-numero];
                            countNeg[-numero] = 0;

                        }

                        if (kth == k) return numero;
                    }
                    numero--;
                }
            }

            return -1;

        }

        static void Main(string[] args)
        {

            //int[] nums = { 3, 2, 3, 1, 2, 4, 5, 5, 6 };
            //int k = 4;

            //Console.WriteLine(FindKthLargest(nums, k));
            ////Output: 4


            //int[] nums = { -1, -1 };
            //int k = 2;
            //Console.WriteLine(FindKthLargest(nums, k));


            //int[] nums = { 3, 2, 3, 1, 2, 4, 5, 5, 6 };
            //int k = 4;
            //Console.WriteLine(FindKthLargest(nums, k)); //4


            //int[] nums = { -5, -4, 0, 1, 5, 9 };
            //int k = 5;
            //Console.WriteLine(FindKthLargest(nums, k));


            int[] nums = { -10, -5, -4, -2, 0, 5,7,9 };
            int k = 7;
            Console.WriteLine(FindKthLargest(nums, k));


            Console.ReadLine();
        }
    }
}
