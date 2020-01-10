https://leetcode.com/problems//submissions/

public int[] SumZero(int n) {
        int mitad = n / 2;

                List<int> arr = new List<int>();

                int aux = mitad;
                for (int i = 0; i < mitad; i++)
                {
                    arr.Add(-aux);
                    aux--;
                }
                aux = 1;
                for (int i = 0; i < mitad; i++)
                {
                    arr.Add(aux);
                    aux++;
                }

                if (n % 2 != 0)
                {
                    arr.Add(0);
                }
                


                return arr.ToArray();
    }