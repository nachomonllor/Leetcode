  public  static int LongestPalindrome(string s)
        {

          
            Dictionary<char, int> dic =
                   new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (dic.ContainsKey(s[i])) { dic[s[i]]++; }
                else { dic[s[i]] = 1; }
            }

            int ans = 0;
           
            int max_impar = 0;
            foreach (KeyValuePair<char, int> kvp in dic)
            {
                if (kvp.Value % 2 != 0)
                {
                    max_impar = Math.Max(max_impar, kvp.Value);
                }
                else
                {
                    ans += kvp.Value;
                }
            }

            bool puse_el_maximo_impar = false;
            foreach (KeyValuePair<char, int> kvp in dic)
            {
                if (kvp.Value % 2 != 0)
                {
                    if (kvp.Value == max_impar && !puse_el_maximo_impar)
                    {
                        ans += max_impar;
                        puse_el_maximo_impar = true;
                    }
     
                    else
                    {
                        ans += kvp.Value - 1;
                    }
                }
            }

      

            return ans;
        }