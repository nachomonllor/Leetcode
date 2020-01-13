https://leetcode.com/problems/word-pattern/
public class Solution {
    public bool WordPattern(string pattern, string str) {
        string[] s = str.Split(' ');
 
            if (s.Length != pattern.Length) return false;
 
            Dictionary<char, string> diccio = new Dictionary<char, string>();
 
            for (int i = 0; i < pattern.Length; i++)
            {
                char key = pattern[i];
                if (diccio.ContainsKey(key))
                {
                    if (diccio[key] != s[i])
                    {
                        return false;
                    }
                }
                else
                {
                    if (diccio.ContainsValue(s[i]))
                    {
                        return false;
                    }
 
                    diccio[key] = s[i];
                }
 
            }
 
            return true;
    }
}
