 https://leetcode.com/problems/replace-elements-with-greatest-element-on-right-side/submissions/

public static int[] ReplaceElements(int[] arr)
        {
            int[] ans = new int[arr.Length];
            int max = -1;
            ans[ans.Length - 1] = -1; 
            for (int i = arr.Length - 1; i >= 1; i--)
            {
                max = Math.Max(max, arr[i]);
                ans[i - 1] = max;
            }

            return ans;
        }
