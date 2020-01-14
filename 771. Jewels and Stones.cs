https://leetcode.com/problems/jewels-and-stones/description/
  public int NumJewelsInStones(string J, string S)
        {
            int cont = 0;
            foreach (char ch in S)
            {
                if (J.Contains(ch))
                {
                    cont++;
                }
            }
            return cont;
        }
