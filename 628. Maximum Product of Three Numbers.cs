https://leetcode.com/problems/maximum-product-of-three-numbers/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        public static int MaximumProduct(int[] nums)
        {
            Array.Sort(nums);
            int na = nums[0];// < 0 ? nums[0] : 0;
            int nb = nums[1]; // < 0 ? nums[1] : 0;

            int pa = nums[nums.Length - 1];// > 0 ? nums[nums.Length - 1] : 0;
            int pb = nums[nums.Length - 2];// > 0 ? nums[nums.Length - 2] : 0;
            int pc = nums[nums.Length - 3]; // > 0 ? nums[nums.Length - 3] : 0;


            return new int[] {na*nb* pa, pa*pb*pc }.Max();
        }

        static void Main(string[] args)
        {

            // int[] Input = { 1, 2, 3, 4 };
            int[] input = { -1, -2, -3 };
            Console.WriteLine(MaximumProduct(input));
            Console.ReadLine();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

      


        public static int MaximumProduct(int[] nums)
        {

            int na = 0, nb = 0, nc = 0;
            int pa = 0, pb = 0, pc = 0;


            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 0)
                {
                    if (nums[i] <= na)
                    {
                        nc = nb;
                        nb = na;
                        na = nums[i];

                    }
                    else if(nums[i] <= nb)
                    {
                        nc = nb;
                        nb = nums[i];
                    }
                    else if(nums[i] < nc)
                    {
                        nc = nums[i];
                    }

                }

                if (nums[i] > 0)
                {
                    if (nums[i] >= pa)
                    {
                        //nb = na;
                        //na = nums[i];
                        pc = pb;
                        pb = pa;
                        pa = nums[i];

                    }
                    else if (nums[i] >= pb)
                    {
                        //nc = nb;
                        //nb = nums[i];
                        pc = pb;
                        pb = nums[i];
                    }
                    else if(nums[i] > pc)
                    {
                        pc = nums[i];
                    }

                }

            }


            int x = na * nb * nc;
            int y = na * nb * pa;
            int z = pa * pb * pc;

            List<int> ans = new List<int>();

            if (x != 0) ans.Add(x);
            if (y != 0) ans.Add(y);
            if (z != 0) ans.Add(z);

            if (ans.Count == 0) return 0;

            return ans.Max();
        }


        static void Main(string[] args)
        {

            //int[] Input = { 1, 2, 3, 4 };
            //int[] input = { -1, -2, -3 };
            int[] input = { 3, 2, 1 };
            //int[] input = { -1, 4, -3 };
            //int[] input = { 1, 2, 3 };
            //int[] input = { -4, -3, -2, -1, 60 }; //720
            //int[] input = { 9, 1, 5, 6, 7, 2 };//378

            Console.WriteLine(MaximumProduct(input));
            Console.ReadLine();
        }
    }
}
