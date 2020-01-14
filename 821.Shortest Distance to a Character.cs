https://leetcode.com/problems/shortest-distance-to-a-character/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        public static  int[] ShortestToChar(string S, char C)
        {
            List<int> indices = new List<int>();
            for(int i =0; i<S.Length; i++)
            {
                if(S[i] == C)
                {
                    indices.Add(i);
                }
            }

            int[] res = new int[S.Length];
            for(int i =0; i<S.Length; i++)
            {
                int MinDif = int.MaxValue;
                foreach(int elem in indices)
                {
                    // MinDif =  Math.Min(MinDif, Math.Abs( Math.Min(elem, i)));
                    MinDif = Math.Min(MinDif, Math.Abs( elem- i));
                }
                res[i] = MinDif;
            }
            return res;
        }

        static void Main(string[] args)
        {
            string S = "loveleetcode";
            char C = 'e';

            foreach(int elem in ShortestToChar(S, C))
            {
                Console.Write(elem + " ");
            }

            Console.ReadLine();
        }
    }
}
