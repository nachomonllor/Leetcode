 https://leetcode.com/problems/maximum-number-of-balloons/submissions/

public static int MaxNumberOfBalloons(string text)
        {
            Dictionary<char, int> dic =
                new Dictionary<char, int>();
            string balloons = "balloon";
            for(int i =0; i<balloons.Length; i++)
            {
                dic[balloons[i]] = 0;
            }
            for(int i =0; i<text.Length; i++)
            {
                if (dic.ContainsKey(text[i]))
                {
                    dic[text[i]]++;
                }
            }
            dic['l'] /= 2;
            dic['o'] /= 2;

            int min = int.MaxValue;

            foreach(KeyValuePair<char, int> kvp in dic)
            {
                min = Math.Min(min, kvp.Value);
            }
            return min;
        }
