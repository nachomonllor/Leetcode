https://leetcode.com/problems/power-of-two/
bool IsPowerOfTwo(int n)
        {
            if (n == 1) return true;
            if (n < 2) return false;
            
            while (n % 2 == 0)
            {
                n /= 2;
            }
            if (n == 1) return true;
            return false;

        }
