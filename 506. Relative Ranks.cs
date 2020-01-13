https://leetcode.com/problems/relative-ranks/description/
public static String[] FindRelativeRanks(int[] nums)
        {
            String[] result = new String[nums.Length];
            int max = nums.Max();
            
            int[] hash = new int[max + 1];
            for (int i = 0; i < nums.Length; i++)
                hash[nums[i]] = i + 1;
            
            int place = 1;
            for (int i = hash.Length - 1; i >= 0; i--)
            {
                if (hash[i] != 0)
                {
                    if (place == 1)
                        result[hash[i] - 1] = "Gold Medal";  
                    else if (place == 2)
                        result[hash[i] - 1] = "Silver Medal";
                    else if (place == 3)            
                        result[hash[i] - 1] = "Bronze Medal";                  
                    else                  
                        result[hash[i] - 1] =  place.ToString();
                    
                    place++;
                }
            }
            return result;
        }
