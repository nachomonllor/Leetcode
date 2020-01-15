using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public class Solution
        {
            public class Solution
            {
                bool divideASiMismo(int n)


                //https://leetcode.com/problems/self-dividing-numbers/description/ 2/2
                {
                    int copia = n;
                    while (n > 0)
                    {
                        int dig = n % 10;
                        if ((dig == 0) || (copia % dig != 0)) return false;
                        n /= 10;
                    }
                    return true;
                }
                public IList<int> SelfDividingNumbers(int left, int right)
                {
                    IList<int> lista = new List<int>();
                    for (int i = left; i <= right; i++)
                    {
                        if (divideASiMismo(i)) lista.Add(i);
                    }
                    return lista;
                }
            }
        }
    }
}
