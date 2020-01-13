https://leetcode.com/problems/range-sum-query-immutable/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class NumArray
    {
        int[] nums;
        //Dictionary<int, int> diccio = new Dictionary<int, int>();
        int[] diccio;
        
        void Precalcular()
        {

            int sum = 0;
            for(int i =0; i<this.nums.Length; i++)
            {
                sum += this.nums[i];
                diccio[i] = sum;
            }

        }

        public NumArray(int[] nums)
        {
            this.nums = nums;
            this.diccio = new int[this.nums.Length];
            Precalcular();
        }

        public int SumRange(int i, int j)
        {
            if (i > 0)
            {
                return diccio[j] - diccio[i-1];
            }
            return diccio[j];

        }
    }


    class Program
    {
       



        static void Main(string[] args)
        {
            int[] nums = { -2, 0, 3, -5, 2, -1 };

            NumArray numArray = new NumArray(nums);

            Console.WriteLine(numArray.SumRange(0, 2));

            Console.ReadLine();
        }
    }
}
