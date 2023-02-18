using Lucene.Net.Util;
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



        //static int binarySearch(int[] arr, int x)
        //{
        //    int l = 0, r = arr.Length - 1;
        //    while (l <= r)
        //    {
        //        int m = l + (r - l) / 2;

        //        // Check if x is present at mid
        //        if (arr[m] == x)
        //            return m;

        //        // If x greater, ignore left half
        //        if (arr[m] < x)
        //            l = m + 1;

        //        // If x is smaller, ignore right half
        //        else
        //            r = m - 1;
        //    }

        //    // if we reach here, then element was
        //    // not present
        //    return -1;
        //}


        //public int[] KWeakestRows(int[][] mat, int k)
        //{
        //    Dictionary<int, int> dic = new Dictionary<int, int>();

        //    int cont = 0;
        //    for (int i = 0; i < mat.Length; i++)
        //    {
        //        cont = 0;
        //        for (int j = 0; j < mat[i].Length; j++)
        //        {
        //            if (mat[i][j] == 1)
        //            {
        //                cont++;
        //            }
        //            else
        //            {
        //                break;
        //            }
        //        }
        //        dic.Add(i, cont);
        //    }

        //    Dictionary<int, int> items = (from pair in dic
        //                                  orderby pair.Value
        //                                  select pair).ToDictionary(x => x.Key, x => x.Value);

        //    List<int> ans = new List<int>();
        //    cont = 0;
        //    foreach (KeyValuePair<int, int> kvp in items)
        //    {
        //        if (cont >= k)
        //        {
        //            break;
        //        }

        //        ans.Add(kvp.Key);
        //        cont++;
        //    }

        //    return ans.ToArray();

        //}


        static int binarySearch(int[] arr)
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
            Dictionary<int, int> dic = new Dictionary<int, int>();
        


            int cont = 0;
            for (int i = 0; i < mat.Length; i++)
            {
                int[] fila = mat[i];
                cont = binarySearch(fila);

                Console.WriteLine(i+ " " + cont);
                dic.Add(i, cont);

            }


            return (from pair in dic
                              orderby pair.Value
                              select pair).ToDictionary(x => x.Key, x => x.Value).Keys.Take(k).ToArray();

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
