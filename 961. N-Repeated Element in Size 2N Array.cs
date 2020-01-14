https://leetcode.com/problems/n-repeated-element-in-size-2n-array/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {


        public int RepeatedNTimes(int[] A)
        {

            Dictionary<int, int> dic = new Dictionary<int, int>();

            for(int i =0; i<A.Length; i++)
            {
                if(dic.ContainsKey(A[i])) dic[A[i]]++;
                else dic[A[i]] = 1;
            }


            int n = A.Length / 2;

            foreach(KeyValuePair<int,int> kvp in dic)
            {
                if (kvp.Value == n) return kvp.Key;
            }

            return -1;


        }



        static void Main(string[] args)
        {

         


            Console.ReadLine();

        }
    }
}
