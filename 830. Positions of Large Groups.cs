https://leetcode.com/problems/positions-of-large-groups/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static IList<IList<int>> LargeGroupPositions(string S)
        {

            IList<IList<int>> ans = new List<IList<int>>();
            char pre = S[0];
            List<int> par = new List<int>();
            int ini = 0;
            int cont = 0;
            bool inicia = false;
            int i;
            for (i = 0; i < S.Length; i++)
            {
                if (S[i] == pre)
                {

                    cont++;
                    if (!inicia)
                    {
                        ini = i;
                        inicia = true;

                    }
                }
                else
                {
                    if (cont >= 3)
                    {
                        if (ini - 1 < 0) par.Add(0); 
                        else  par.Add(ini - 1);
                        par.Add(i - 1);
                        ans.Add(par);
                    }
                    cont = 1;
                    inicia = false;
                    pre = S[i];
                    ini = 0;
                    par = new List<int>();
                }
            }
            if (cont >= 3)
            {
                if (ini - 1 < 0) par.Add(0);
                else par.Add(ini - 1);
                par.Add(i - 1);
                ans.Add(par);
            }
            return ans;
        }


        static void Main(string[] args)
        {

            //string input = "abcdddeeeeaabbbcd";
            string input = "aaa";
            // Output: [[3, 5],[6,9],[12,14]]

            foreach(List<int> elem in LargeGroupPositions(input))
            {
                foreach(int x in elem)
                {
                    Console.Write(x + " ");
                }
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}
