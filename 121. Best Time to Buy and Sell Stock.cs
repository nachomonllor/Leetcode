https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
   public static int MaxProfit(int[] prices)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            int indice_min = -1;
            int indice_max = -1;
            int max_dif = -1;

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < min)
                {
                    min = prices[i];
                    indice_min = i;
                }
                if (i > indice_min)
                {
                    //Console.WriteLine(prices[i] + " " + prices[indice_min]+ " : " +
                    //    (prices[i] - prices[indice_min]));
                    max_dif = Math.Max(max_dif, (prices[i] - prices[indice_min]));
                }
            }

            if (max_dif < 0) return 0;

            return max_dif;

        }
