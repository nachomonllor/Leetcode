

https://leetcode.com/problems/top-k-frequent-elements/
public static IList<int> TopKFrequent(int[] nums, int k)
        {

            IList<int> r = new List<int>();
            if (k == 0)
                return r;
            Array.Sort(nums);
            Dictionary<int, int> map = new Dictionary<int, int>();
            foreach (int n in nums)
            {
                if (map.ContainsKey(n)) map[n]++;
                else map[n] = 1;
            }
            map = map.OrderByDescending(o => o.Value).ToDictionary(d => d.Key, d => d.Value);
            int i = 0;
            foreach (int s in map.Keys)
            {
                if (i == k) break;
                r.Add(s);
                i++;
            }
            return r;
        }
