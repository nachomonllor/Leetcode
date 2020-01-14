https://leetcode.com/problems/first-missing-positive/

public static int FirstMissingPositive(int[] nums)
        {
            /*como no se cual es el maximo elemento
             declaro un array de bool de 2 millones*/
            bool[] marcas = new bool[2000000];
 
            /* como hay que buscar el primer POSITIVO
             me fijo que nums[i] sea positivo,
             a los negativos los ignoro */
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    marcas[nums[i]] = true;
                }
            }
 
            /* luego busco al primero que quedo en false */
            for (int i = 1; i < marcas.Length; i++)
            {
                if (!marcas[i])
                {
                    return i;
                }
            }
 
           
            return 0;
        }

