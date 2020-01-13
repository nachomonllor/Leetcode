https://leetcode.com/problems/word-break/
public static bool  WordBreak(String s, ISet<String> wordDict)
        {
            int[] pos = new int[s.Length + 1];

            //Arrays.fill(pos, -1);
            for (int i = 0; i < pos.Length; i++)
            {
                pos[i] = -1;
            }

            pos[0] = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (pos[i] != -1)
                {
                    for (int j = i + 1; j <= s.Length; j++)
                    {
                        String sub = s.Substring(i,  j - i);
                        if (wordDict.Contains(sub))
                        {
                            pos[j] = i;
                        }
                    }
                }
            }

            return pos[s.Length] != -1;
        }
