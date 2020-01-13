https://leetcode.com/problems/largest-number/
  public static string LargestNumber(int[] nums)
        {
            int i;
            for ( i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    string a = (nums[i] + "" + nums[j]).ToString();
                    string b = (nums[j] + "" + nums[i]).ToString();

                    if (long.Parse(b) > long.Parse(a))
                    {
                        long temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = (int)temp;
                    }
                }
            }

            string sinCeros = string.Join("", nums);

            i = 0;
            while(i < sinCeros.Length && sinCeros[i] == '0')
            {
                i++;
            }

            string res = sinCeros.Substring(i);
            if (res.Length == 0) return "0";

            return res;
        }
