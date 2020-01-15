using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        //public static int FindSpecialInteger(int[] arr)
        //{
        //    Dictionary<int, int> dic = new Dictionary<int, int>();
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (dic.ContainsKey(arr[i]))
        //        {
        //            dic[arr[i]]++;
        //        }
        //        else
        //        {
        //            dic[arr[i]] = 1;
        //        }
        //        if (dic[arr[i]] > arr.Length * 0.25)
        //        {
        //            return arr[i];
        //        }
        //    }

        //    //foreach (KeyValuePair<int, int> kvp in dic)
        //    //{
        //    //    if (kvp.Value > arr.Length * 0.25)
        //    //    {
        //    //        return kvp.Key;
        //    //    }
        //    //}
        //    return -1;

        //}

        public static int FindSpecialInteger(int[] arr)
        {
            int[] dic = new int[100001];
            for (int i = 0; i < arr.Length; i++)
            {
                dic[arr[i]]++;
                if (dic[arr[i]] > arr.Length * 0.25)
                {
                    return arr[i];
                }
            }
            return -1;

        }
        static void Main(string[] args)
        {

            int[] arr = { 1, 2, 2, 6, 6, 6, 6, 7, 10 };
            Console.WriteLine(FindSpecialInteger(arr)); 



            Console.ReadLine();

        }
    }
}
