using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2363_Merge_Similar_Items
{
    internal class Program
    {

        public static  IList<IList<int>> MergeSimilarItems(int[][] items1, int[][] items2)
        {

            SortedDictionary<int, int> dic = new SortedDictionary<int, int>();

            
            for(int i = 0; i < items1.Length; i++)
            {
                int key = items1[i][0];
                int val = items1[i][1];
                if (dic.ContainsKey(key))
                {
                    dic[key] += val;
                }
                else
                {
                    dic[key] = val;
                }
            }

            for (int i = 0; i < items2.Length; i++)
            {
                int key = items2[i][0];
                int val = items2[i][1];
                if (dic.ContainsKey(key))
                {
                    dic[key] += val;
                }
                else
                {
                    dic[key] = val;
                }
            }

            IList<IList<int>> list = new List<IList<int>>();

            foreach(KeyValuePair<int, int> kvp in dic)
            {
                IList<int> aux = new List<int>();
                aux.Add(kvp.Key);
                aux.Add(kvp.Value);
                list.Add(aux);
            }

            return list;
        }


        static void Main(string[] args)
        {
            //Input: items1 = [[1, 1],[4,5],[3,8]], items2 = [[3, 1],[1,5]]
            //Output: [[1,6],[3,9],[4,5]]

            int[][] items1 = { new int[]  { 1, 1 },  new int[] { 4, 5 }, new int[] { 3, 8 } };
            int[][] items2 = { new int[] { 3, 1 }, new int[] { 1, 5 } };


            IList<IList<int>> list = MergeSimilarItems(items1, items2);

            foreach(IList<int> item in list)
            {

                foreach(int i in item)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}
