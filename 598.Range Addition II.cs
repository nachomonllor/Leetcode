https://leetcode.com/problems/range-addition-ii/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {



        public static int MaxCount(int m, int n, int[,] ops)
        {

            List<string> nueva = new List<string>();
            int i;
            for( i =0; i<ops.GetLength(0); i++)
            {
                nueva.Add(ops[i, 0] + " " + ops[i, 1]);
            }

            HashSet<string> hs = new HashSet<string>(nueva);

            int[,] unicos = new int[hs.Count, 2];

             i = 0;
            foreach(string elem in hs)
            {
                unicos[i, 0] = int.Parse( elem.Split(' ')[0]);
                unicos[i, 1] = int.Parse(elem.Split(' ')[1]);
                i++;
            }


            int minFila = int .MaxValue;
            int minCol = int.MaxValue;

            int cantMinFilas = 0, cantMinColumnas = 0;
            for( i =0; i< unicos.GetLength(0); i++)
            {
                //minFila = Math.Min(minFila, ops[i, 0]);
                //minCol = Math.Min(minCol, ops[i, 1]);

                if(unicos[i,0] < minFila)
                {
                    minFila = unicos[i, 0];
                    cantMinFilas=1;
                }
                else if(unicos[i, 0] == minFila)
                {
                    cantMinFilas++;
                }

                if(unicos[i,1] < minCol)
                {
                    minCol = unicos[i, 1];
                    cantMinColumnas = 1;
                }else if(ops[i,1] == minCol)
                {
                    cantMinColumnas++;
                }

            }

            if (hs.Count == 0) return m * n;
            //return minFila * minCol * ops.GetLength(0);
            return minFila   * minCol  ;
        }



        static void Main(string[] args)
        {
            //int m = 3;
            //int n = 3;
            //int[,] operations = { { 2, 2 }, { 3, 3 } };


            int m = 39999;
            int n = 39999;
            int[,] operations = { { 19999, 19999 } };


            //int m = 3;
            //int n = 3;
            //int[,] operations = { { 2, 2 }, { 3, 3 }, { 3, 3 }, { 3, 3 }, { 2, 2 }, { 3, 3 }, { 3, 3 }, { 3, 3 }, { 2, 2 }, { 3, 3 }, { 3, 3 }, { 3, 3 } };


            //int n = 3;
            //int m = 3;
            //int[,] operations = new int[0, 0];


            Console.WriteLine(MaxCount(m, n, operations));


            Console.ReadLine();
        }
    }
}
