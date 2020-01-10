https://leetcode.com/problems/minimum-increment-to-make-array-unique/submissions/

public class Solution {
    public int MinIncrementForUnique(int[] A) {
        Array.Sort(A);
                int ans = 0;
                for (int i = 1; i < A.Length; i++)
                {
                    //while (A[i] <= A[i - 1])
                    //{
                    //    A[i]++;
                    //    ans++;
                    //}
                    if (A[i] <= A[i - 1])
                    {
                        ans += A[i - 1] - A[i] + 1;
                        A[i] += A[i - 1] - A[i] + 1;
                        
                    }
                }
                return ans;
    }
}