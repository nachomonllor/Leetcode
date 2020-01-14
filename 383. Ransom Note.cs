https://leetcode.com/problems/ransom-note/#_=_
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static public bool CanConstruct(string ransomNote, string magazine)
        {
            var drn = new Dictionary<char, int>();

            //foreach (char ch in ransomNote)
            //{
            //    if (drn.ContainsKey(ch))
            //    {
            //        drn[ch]++;
            //    }
            //    else
            //    {
            //        drn[ch] = 1;
            //    }
            //}
            drn = ransomNote.GroupBy(c => c) // put each character into a "bucket"
                // order the buckets alphabetically

                     // then convert to dictionary where key = character, value = count
                     .ToDictionary(grp => grp.Key, grp => grp.Count());

            var dm = new Dictionary<char, int>();
            //foreach (char ch in magazine)
            //{
            //    if (dm.ContainsKey(ch))
            //    {
            //        dm[ch]++;
            //    }
            //    else
            //    {
            //        dm[ch] = 1;
            //    }
            //}
            dm = magazine.GroupBy(c => c) // put each character into a "bucket"
                // order the buckets alphabetically

                     // then convert to dictionary where key = character, value = count
                     .ToDictionary(grp => grp.Key, grp => grp.Count());

            foreach (KeyValuePair<char, int> kvp in drn)
            {
                if (!dm.ContainsKey(kvp.Key))
                {
                    return false;
                }
                else
                {
                    if (kvp.Value > dm[kvp.Key])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        static void Main(string[] args)
        {

           string a = "fffbfg";
           string b = "effjfggbffjdgbjjhhdegh";

            Console.WriteLine(CanConstruct(a,b));
            Console.ReadLine();

        }

    }
}


