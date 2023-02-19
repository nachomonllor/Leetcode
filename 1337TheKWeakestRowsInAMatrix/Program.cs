using System;
using System.Collections.Generic;
using System.Linq;



namespace _1337TheKWeakestRowsInAMatrix
{
    class Program
    {

        //SOLUCION DE CHATGPT (Supera al 96 %)
        public int[] KWeakestRowsCHATGPT(int[][] mat, int k)
        {
            // Create a list of tuples where each tuple contains the number of soldiers and the index of the row
            List<(int soldiers, int index)> rows = new List<(int, int)>();
            for (int i = 0; i < mat.Length; i++)
            {
                int soldiers = 0;
                for (int j = 0; j < mat[i].Length; j++)
                {
                    soldiers += mat[i][j];
                }
                rows.Add((soldiers, i));
            }
            // Sort the list of tuples by the number of soldiers (ascending) and then by the index of the row (ascending)
            rows.Sort((x, y) => x.soldiers == y.soldiers ? x.index - y.index : x.soldiers - y.soldiers);
            // Create an array with the indices of the k weakest rows
            int[] result = new int[k];
            for (int i = 0; i < k; i++)
            {
                result[i] = rows[i].index;
            }
            return result;
        }



        static  int binarySearch(int[] arr)
        {

            int l = 0, r = arr.Length - 1;

            if (arr[0] == 0) return 0;
            if (arr.Last() == 1) return arr.Length;

            while (l <= r)
            {
                int m = l + (r - l) / 2;

                if (arr[m] == 1 && m+1 < arr.Length &&  arr[m+1] == 0)
                    return m + 1;

                if (arr[m] == 1 && m+1 < arr.Length &&  arr[m+1] == 1)
                    l = m + 1;

                if (arr[m] == 0  && m+1 < arr.Length && arr[m+1] == 0)
                    r = m - 1;

                if (l == r) return l + 1;

                if (r <= 0) return 0;

                if (l >= arr.Length-1) return arr.Length;

            }

            return arr.Length;
        }


        public static int[] KWeakestRows(int[][] mat, int k)
        {
            var dic = new SortedDictionary<int, List<int>>();

            int cont = 0;
            for (int i = 0; i < mat.Length; i++)
            {
                int[] fila = mat[i];
                cont = binarySearch(fila);

                if(dic.ContainsKey(cont))
                {
                    dic[cont].Add(i);
                }
                else
                {
                    dic[cont] = new List<int>();
                    dic[cont].Add(i);
                }

            }


            List<int> ans = new List<int>();
            cont = 0;
            foreach (KeyValuePair<int, List< int > >  kvp in dic)
            {
                List<int> rows = kvp.Value;
                rows.Sort();

                foreach(int item in rows)
                {
                    if (cont >= k) return ans.ToArray();
                    ans.Add(item);
                    cont++;
                }
            }

            return ans.ToArray();

        }

        static void Main(string[] args)
        {


            int[][] mat =
            {
             new int[] {1, 1, 0, 0, 0}, //2
             new int[] {1, 1, 1, 1, 0}, //4
             new int[] {1, 0, 0, 0, 0}, //1
             new int[] {1, 1, 0, 0, 0}, //2
             new int[] {1, 1, 1, 1, 1}  //5
            };

            int k = 3;
            //Output: [2,0,3]

            //int k = 2;
            //int[][] mat = {
            //    new int[] { 1, 0 }, //1
            //    new int[] { 0, 0 }, //0
            //    new int[] { 1, 0 }
            //}; //[1,0]



            //int[][] mat =
            //     {
            //     new int [] {1,1,0 },//2
            //     new int [] {1,0,0 },//1
            //     new int[] {1,0,0 }, //1
            //     new int[] {1,1,1 }, //3
            //     new int[] {1,1,0 }, //2
            //     new int [] {0,0,0 } };//0
            //  //[5,1,2,0]
            //int k = 4;

            foreach (int item in KWeakestRows(mat, k))
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();
        }
    }
}
