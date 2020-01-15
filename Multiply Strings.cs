public class Solution {
    public string Multiply(string num1, string num2) {
        
        string C = "";
            int next = 0;
            int i;
            for (int k = 0; k < num1.Length + num2.Length - 1; k++)
            {
                int cur = next;
                int  j;
                if (k < num1.Length)
                {
                    i = num1.Length - 1 - k;
                    j = num2.Length - 1;
                }
                else
                {
                    i = 0;
                    j = num1.Length + num2.Length - 2 - k;
                }
                while (i < num1.Length && j >= 0)
                {
                    cur += int.Parse(num1[i].ToString()) * int.Parse(num2[j].ToString());
                    i++;
                    j--;
                }

                C = C.Insert(0, (cur % 10).ToString());
                next = cur / 10;

            }
            if (next > 0)
            {
                C = C.Insert(0, next.ToString());
            }

            i=0;
            while (i < C.Length && C[i] == '0')
            {
                i++;
            }

            C = C.Substring(i, C.Length-i);

            if (C == "") C = "0";

            return C;
    }
}
