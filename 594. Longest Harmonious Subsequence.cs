https://leetcode.com/problems/longest-harmonious-subsequence/description/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp62
{
    class Program
    {

        

public static int FindLHS(int[] nums)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            foreach (int elem in nums)
            {
                if (dictionary.ContainsKey(elem))
                    dictionary[elem]++;
                else
                    dictionary[elem] = 1;
            }

            int max = 0;
            foreach(KeyValuePair<int,int> kvp in dictionary)
                if(dictionary.ContainsKey(kvp.Key+1)) //no es necesario chequear +1 y -1 juntos 
                    max = Math.Max(max, kvp.Value + dictionary[kvp.Key + 1]);
            
            return max;
        }

        static void Main(string[] args)
        {
            int[] a = { 1, 3, 2, 2, 5, 2, 3, 7 };

            Console.WriteLine(FindLHS(a));

             Console.ReadLine();
        }
    }
}
