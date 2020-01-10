public bool UniqueOccurrences(int[] arr)
        {
            Dictionary<int, int> diccio =
                new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (diccio.ContainsKey(arr[i]))
                {
                    diccio[arr[i]]++;
                }
                else
                {
                    diccio[arr[i]] = 1;
                }
            }

           // HashSet<int> hash =
             //   new HashSet<int>(arr);

            return diccio.Values.ToArray().Distinct().ToArray().Length == diccio.Count;

        }