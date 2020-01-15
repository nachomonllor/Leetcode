public class Solution
        {
            public bool ContainsNearbyDuplicate(int[] nums, int k)
            {
                int n = nums.Length;
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (nums[i] == nums[j] && j - i <= k)
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
        }