
https://leetcode.com/problems/intersection-of-two-arrays/
public static  int[] intersection(int[] nums1, int[] nums2)
        {
            var hs = new HashSet<int>();
            foreach (int elem in nums1)
            {
                if (nums2.Contains(elem))
                {
                    hs.Add(elem);
                }
            }
            return hs.ToArray();
        }
