using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2160MinimumSumOfFourDigitNumberAfterSplittingDigits
{
    class Program
    {

        public static bool nextPermutation(char[] array)
        {
            // Find non-increasing suffix
            int i = array.Length - 1;
            while (i > 0 && array[i - 1] >= array[i])
                i--;
            if (i <= 0)
                return false;

            // Find successor to pivot
            int j = array.Length - 1;
            while (array[j] <= array[i - 1])
                j--;
            char temp = array[i - 1];
            array[i - 1] = array[j];
            array[j] = temp;

            // Reverse suffix
            j = array.Length - 1;

            while (i < j)
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
                i++;
                j--;
            }
            return true;
        }

        public static int MinimumSum(int num)
        {
            // List<string> permut = new List<string>();
            string sorted = new string((num+"").OrderBy(c => c).ToArray());

            char[] chars = sorted.ToCharArray();

            int min = num;
            do
            {
                string aux = new string(chars);
                for(int i = 1; i + 1 < aux.Length; i++)
                {
                    int a = int.Parse(aux.Substring(0, i));
                    int b = int.Parse(aux.Substring(i));
                    min = Math.Min(min, a + b); 
                }
                //Console.WriteLine(aux);
            } while (nextPermutation(chars));

            return min;
        }


        static void Main(string[] args)
        {

            int num = 2932;
            //Output: 52

            Console.WriteLine(MinimumSum(num));


            Console.ReadLine();
        }
    }
}
