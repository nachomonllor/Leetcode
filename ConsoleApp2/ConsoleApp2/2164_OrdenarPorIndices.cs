using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class _2164_OrdenarPorIndices
    {

        public int[] SortEvenOdd(int[] nums)
        {
            List<int> indicePares = new List<int>();
            List<int> indicesImpares = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (i % 2 == 0)
                {
                    indicePares.Add(nums[i]);
                }
                else
                {
                    indicesImpares.Add(nums[i]);
                }
            }

            indicePares.Sort();
            indicesImpares.Sort();
            indicesImpares.Reverse();

            List<int> result = new List<int>();

            int indicePar = 0;
            int indiceImpar = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if(i % 2 == 0)
                {
                    result.Add(indicePares[indicePar]);
                    indicePar++;
                }
                else
                {
                    result.Add(indicesImpares[indiceImpar]);
                    indiceImpar++;
                }
            }

            return result.ToArray();    
        }

    }
}
