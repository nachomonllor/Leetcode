https://leetcode.com/submissions/detail/233118577/

public int[] TwoSum(int[] numbers, int target) {
        Dictionary<int, int> hash = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (hash.ContainsKey(target - numbers[i]))
                {
                    int[] r = new int[] { hash[target - numbers[i]], i };
                    Array.Sort(r);
                    return r;
                }
                hash[numbers[i]] = i;
            }

            return new int[] { -1, -1 };
    }
