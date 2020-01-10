 
https://leetcode.com/problems/height-checker/discuss/?currentPage=1&orderBy=hot&query=

public int HeightChecker(int[] heights)
        {
            int[] ordenado = heights.ToArray();
            Array.Sort(ordenado);
            int cont = 0;
            for (int i = 0; i < heights.Length; i++)
            {
                if (ordenado[i] != heights[i])
                {
                    cont++;
                }
            }
            return cont;
        }