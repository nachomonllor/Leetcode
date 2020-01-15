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

            public static int reverse(int x)
            {
                bool negativo = x < 0;
                if (negativo)
                {
                    x = x * -1;
                }
                int digitos = (int)Math.Pow(10, ((int)Math.Log10(x)));
                int invertido = 0;
                int digActual;
                while (x > 0)
                {
                    digActual = x % 10;
                    invertido += digActual * digitos;
                    digitos = digitos / 10;
                    x = x / 10;
                }
                if (negativo)
                {
                    return invertido * -1;
                }
                return invertido;
            }

        }



    }
}