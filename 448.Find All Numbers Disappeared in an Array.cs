https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {


        public static IList<int> FindDisappearedNumbers(int[] nums)
        {
            List<int> lista = new List<int>();
            if (nums.Length == 0) return lista;
            HashSet<int> hs = new HashSet<int>(nums);
            //int max = nums.Max();

            
            for(int i =1; i<=nums.Length; i++)
            {
                if (!hs.Contains(i)) lista.Add(i);
            }
            return lista;
        }


        static void Main(string[] args)
        {
            //int[] arr = { 4, 3, 2, 7, 8, 2, 3, 1 };
            int[] arr = {1,1 };
            foreach (int elem in FindDisappearedNumbers(arr))
            {
                Console.Write(elem + " ");
            }

            Console.ReadLine();
        }
    }
}

