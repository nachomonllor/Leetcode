https://leetcode.com/problems/fibonacci-number/

public static  int Fib(int N)
        {
            if (N == 0) return 0;
            if (N <= 2) return 1;
            int a = 0, b = 1;
            int c = a + b;

            for (int i = 2; i < N; i++)
            {
                
                a = b;
                b = c;
                c = a + b;
            }
            return c;
        }