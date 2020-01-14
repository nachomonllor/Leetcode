https://leetcode.com/problems/summary-ranges/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
      
        public static IList<string> SummaryRanges(int[] nums)
        {
            int i = 0;
            List<string> lista = new List<string>();

            while (i < nums.Length)
            {
                int ini = nums[i]; //cargo el inicio donde esta posicionado i
                /*
                 mientras el numero actual +1 sea igual al numero siguiente: es porque son consecutivos
                 */
                while (i + 1 < nums.Length && nums[i] + 1 == nums[i + 1])
                {
                    i++;
                }
                
                //cargo a fin donde quedo i, i quedo en el ultimo de la izquierda que no tiene consecutivo a la derecha
                int fin = nums[i];


                if (ini == fin) //si el inicio es igual al fin es porque no hay rango de 2 numeros
                {
                    lista.Add(ini.ToString());
                }
                else //hay rango
                {
                    lista.Add(ini.ToString() + "->" + fin.ToString());
                }

                
                i++; //me posiciono en el sig numero, que contendra el siguiente rango
            }

            return lista;
        }


        static void Main(string[] args)
        {
            //int[] arr = { 0, 1, 2,
            //              4, 5, 6, 7, 8, 9,
            //              14 };
            int[] arr = {0,1,2,4,5,7 };

           IList<string> lista =   SummaryRanges(arr);

           foreach (string s in lista)
           {
               Console.WriteLine(s);
           }


            Console.ReadLine();

        }

    }
}
