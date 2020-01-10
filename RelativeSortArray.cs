
https://leetcode.com/problems/relative-sort-array/submissions/


   public static int[] RelativeSortArray(int[] arr1, int[] arr2)
        {
            int[] frec_arr1 = new int[1001];

            //HashSet<int> hash = new HashSet<int>(arr2);
            int[] hash = new int[1001];
            for (int i = 0; i < arr2.Length; i++)
            {
                hash[arr2[i]]++;
            }
            int[] frec_resto = new int[1001];
            for (int i = 0; i < arr1.Length; i++)
            {
                frec_arr1[arr1[i]]++;

                //if (!hash.Contains(arr1[i]))
                if(hash[arr1[i]] == 0)
                {
                    frec_resto[arr1[i]]++;
                }
            }


            int k = 0;
            for (int i = 0; i < arr2.Length; i++)
            {
                //for (int j = 0; j < frec_arr1[arr2[i]]; j++)
                while(frec_arr1[arr2[i]]-- > 0)
                {
                    arr1[k++] = arr2[i];
                }
            }

            for (int i = 0; i < 1001; i++)
            {
                //for (int j = 0; j < frec_resto[i]; j++)
                while(frec_resto[i]-- > 0)
                {
                    // ans.Add(i);
                    arr1[k++] = i;
                }
            }

            

            //return ans.ToArray();
            return arr1;

        }