https://leetcode.com/problems/assign-cookies/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

     


        //public int FindContentChildren(int[] g, int[] s)
        //{
        //    int cont = 0;
        //    Array.Sort(s);
        //    for (int i = 0; i < g.Length; i++)
        //    {
        //        for (int j = 0; j < s.Length; j++)
        //        {
        //            if (s[j] >= g[i])
        //            {
        //                cont++;
        //                s[j] = -1;
        //                break;
        //            }
        //        }
        //    }
        //    return cont;
        //}

        public int FindContentChildren(int[] g, int[] s)
        {
             
            Array.Sort(s);
            Array.Sort(g);
            int i = 0, j = 0;

            for(j=0, i=0; i<g.Length && j < s.Length; j++)
            {
                if (g[i] <= s[j]) i++;
            }
            return i;
        }


        static void Main(string[] args)
        {

          

        


            Console.ReadLine();
        }
    }
}
