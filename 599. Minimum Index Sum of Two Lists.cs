https://leetcode.com/problems/minimum-index-sum-of-two-lists/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {


        public static string[] FindRestaurant(string[] list1, string[] list2)
        {

            Dictionary<string, int> da = new Dictionary<string, int>();
            for (int i = 0; i < list1.Length; i++)
            {
                  da[list1[i]]=i;
            }

            Dictionary<string, int> db = new Dictionary<string, int>();
            for (int i = 0; i < list2.Length; i++)
            {
                 db[list2[i]]=i;
            }


            int minSum = int.MaxValue;
            List<string> ans = new List<string>();
            foreach (KeyValuePair<string, int> kvp in da)
            {
                if (db.ContainsKey(kvp.Key))
                {
                    if (kvp.Value + db[kvp.Key] < minSum)
                    {
                        //comun = kvp.Key;
                        minSum = kvp.Value + db[kvp.Key];
                        ans = new List<string>();
                        ans.Add(kvp.Key);
                    }
                    else if(kvp.Value + db[kvp.Key] == minSum)
                    {
                        ans.Add(kvp.Key);
                    }
                }
            }

            return ans.ToArray();

        }


        static void Main(string[] args)
        {

            //string[] a = { "Shogun", "Tapioca Express", "Burger King", "KFC" };
            //string[] b = { "Piatti", "The Grill at Torrey Pines", "Hungry Hunter Steakhouse", "Shogun" };

            string[] a = { "Shogun", "Tapioca Express", "Burger King", "KFC" };
            string[] b = { "KFC", "Shogun", "Burger King" };

            foreach (string elem in FindRestaurant(a, b))
            {
                Console.Write(elem + " ");
            }



            Console.ReadLine();
        }
    }
}
