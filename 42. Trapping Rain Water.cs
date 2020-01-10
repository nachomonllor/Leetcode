 public static int Trap(int[] height)
        {

            int sum = 0;
            int[] izq = new int[height.Length];

            izq[0] = height[0];

            for (int i = 1; i < height.Length; i++)
            {
                izq[i] = Math.Max(izq[i - 1], height[i]);
            }
            int[] der = new int[height.Length];
            der[height.Length - 1] = height[height.Length - 1];
            for (int i = height.Length - 2; i >= 0; i--)
            {
                der[i] = Math.Max(der[i + 1], height[i]);
            }

            for (int i = 0; i < height.Length; i++)
            {
                sum += Math.Min(izq[i], der[i]) - height[i];
            }

            return sum;
        }