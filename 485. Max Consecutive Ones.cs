https://leetcode.com/problems/max-consecutive-ones/description/
  public int FindMaxConsecutiveOnes(int[] nums)
        {
            int max = 0;
            int cont = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    cont++;
                }
                else
                {
                    max = Math.Max(max, cont);
                    cont = 0;
                }
            }
            max = Math.Max(max, cont);
            return max;
        }


public int findMaxConsecutiveOnes(int[] nums)
        {
            int max = 0;
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (nums[i] == 0)    // reset sum to zero when encounters zeros
                    sum = 0;
                else                // keep update max
                    max = Math.Max(max, sum);
            }
            return max;
        }
