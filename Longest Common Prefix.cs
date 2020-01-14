https://leetcode.com/problems/longest-common-prefix/

public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs == null || strs.Length == 0)
            {
                return "";
            }
           
 
            int minLen = strs[0].Length;
            for (int i = 0; i < strs.Length; i++)
            {
                minLen = Math.Min(strs[i].Length, minLen);
            }
 
            string prefix = "";
            for (int col = 0; col < minLen; col++)
            {
                //bool flag = true;
                int fila;
                for ( fila = 0; fila < strs.Length; fila++)
                {
                    if (strs[fila][col] != strs[0][col])
                    {
                       // flag = false;
                        return prefix;
                    }
                }
                prefix += strs[fila-1][col];
            }
 
            return prefix;
    }
}
