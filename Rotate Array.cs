  //  https://leetcode.com/problems/rotatearray/
        public void Rotate(int[] nums, int k)
        {
            if (k > nums.Length)
            {
                k = k % nums.Length;
            }
            int[] copia = new int[nums.Length];
            for (int i = 0; i < nums.Length - k; i++)
            {
                copia[i + k] = nums[i];
            }

            for (int i = nums.Length - k; i < nums.Length; i++)
            {
                copia[i - (nums.Length - k)] = nums[i];
            }
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = copia[i];
            }
        }