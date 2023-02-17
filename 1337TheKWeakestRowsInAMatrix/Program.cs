using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1337TheKWeakestRowsInAMatrix
{
    class Program
    {


        public int[] KWeakestRows(int[][] mat, int k)
        {
           Dictionary<int,int > dic = new Dictionary<int,int>();

            int cont = 0;
            for(int i = 0; i < mat.Length; i++)
            {
                cont = 0;
                for(int j = 0; j < mat[i].Length; j++)
                {
                    if(mat[i][j] == 1)
                    {
                        cont++;
                    }
                }
                dic.Add(i, cont);
            }

            Dictionary<int,int> items =  (from pair in dic
                        orderby pair.Value 
                        select pair).ToDictionary(x => x.Key, x => x.Value);

            List<int> ans = new List<int>();
            cont = 0;
            foreach(KeyValuePair<int,int> kvp in items)
            {
                if(cont >= k)
                {
                    break;
                }

                ans.Add(kvp.Key);
                cont++;
            }

            return ans.ToArray();
           // return items.Values.ToArray();

        }

        static void Main(string[] args)
        {





            Console.ReadLine();
        }
    }
}
