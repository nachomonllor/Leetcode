 public int CountPrimeSetBits(int L, int R)
        {
            HashSet<int> primos = new HashSet<int>(new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 });
            int ans = 0;
            for (int i = L; i <= R; i++)
            {
                int contBits = Convert.ToString(i, 2).Count(e => e == '1');
                if (Array.BinarySearch(primos.ToArray(), contBits) >= 0)
                {
                    ans++;
                }
            }
            return ans;
        }