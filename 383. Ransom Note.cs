using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public class Solution
        {

            public bool CanConstruct(string ransomNote, string magazine)
            {
                var drn = new Dictionary<char, int>();

                drn = ransomNote.GroupBy(c => c) // put each character into a "bucket"
                    // order the buckets alphabetically

                         // then convert to dictionary where key = character, value = count
                         .ToDictionary(grp => grp.Key, grp => grp.Count());

                var dm = new Dictionary<char, int>();

                dm = magazine.GroupBy(c => c) // put each character into a "bucket"
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


        }



    }
}
