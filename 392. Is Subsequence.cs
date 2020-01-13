https://leetcode.com/problems/is-subsequence/
  public static bool IsSubsequence(string s, string t)
        {
            if (s.Length == 0) return true;
            int j = 0;
            for(int i =0; i<t.Length; i++)
            {
                if(s[j] == t[i])
                {
                    j++;
                }
                if (j == s.Length) return true;
            }
            return false;
        }
