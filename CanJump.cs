https://leetcode.com/problems/jump-game/#/description


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        public static bool CanJump(int[] nums)
        {
            if (nums[0] == 0 && nums.Length > 1) return false;
            if (nums[0] == 0) return true;
            if (nums.Length == 1) return true;
            int i = nums.Length - 1;

            int ind_mas_lejano = i;
            int max = nums[nums.Length - 1];
            while (i >= 0)
            {
                while (i >= 0 && nums[i] >= ind_mas_lejano - i)
                {
                    ind_mas_lejano = i;
                    max = nums[ind_mas_lejano];
                    i--;
                }
                //Console.WriteLine(ind_mas_lejano + " " + max);
                Console.WriteLine(i);  

                i--;
            }
            if (nums[0] < ind_mas_lejano )
            {
                return false;
            }

           // Console.WriteLine(i);

            return true;
        }



        static void Main(string[] args)
        {
            //int[] A = { 2, 3, 1, 1, 4 };
            //int[] A = { 3, 2, 1, 0, 4 };
            //int[] A = { 0 };
            //int[] A = { 2, 0 }; //true
            // int[] A = { 2, 0, 0 }; //true
            // int[] A = { 2, 5, 0, 0 };//true
            // int[] A = { 1, 2, 3 };//true
            //int[] A = { 0, 1 }; //false
            // int[] A = { 1, 0, 2 }; //false
             //int[] A = { 1, 2 };//true

            int[] A = { 1, 1, 1, 0 };//true

            // int[] A = { 3, 0, 8, 2, 0, 0, 1 }; //true
                       //0  1  2  3  4  5  6

            Console.WriteLine(CanJump(A));

            Console.ReadLine();
        }
    }
}
