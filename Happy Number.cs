https://leetcode.com/problems/happy-number/
public class Solution {
    
     int SumaDigPow2(int n)
        {
            int copia = n;
            int sum = 0;

            while (copia > 0)
            {
                int dig = copia % 10;
                sum += dig * dig;
                copia /= 10;
            }
            return sum;
        }

        public bool IsHappy(int n)
        {
            int primer = n;
            HashSet<int> hash = new HashSet<int>();

            do
            {
                if (hash.Contains(primer) && primer != 1)
                {
                    return false;
                }

                hash.Add(primer);

                primer = SumaDigPow2(primer);
               // Console.WriteLine(primer);

            } while (primer != n && primer != 1);

            //Console.WriteLine(primer);
            if (primer == 1) return true;

            return false;
        }
    
    
}

-------EN UNA FUNCION------
public class Solution {
      public  bool IsHappy(int n)
        {
            int primer = n;
            HashSet<int> hash = new HashSet<int>();
 
            do
            {
                if (hash.Contains(primer) && primer != 1)
                {
                    return false;
                }
 
                hash.Add(primer);
 
                int copia = primer;
                int sum = 0;
 
                while (copia > 0)
                {
                    int dig = copia % 10;
                    sum += dig * dig;
                    copia /= 10;
                }
                primer = sum;
 
                if (primer == 1) return true;
 
            } while (primer != n);
 
            //if (primer == 1) return true;
 
            return false;
        }
}

