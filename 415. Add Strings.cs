https://leetcode.com/problems/add-strings/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        public static string AddStrings(string num1, string num2)
        {
            int maxLen = Math.Max(num1.Length, num2.Length);

            num1 = new string('0', maxLen - num1.Length) + num1;
            num2 = new string('0', maxLen - num2.Length) + num2;

            //Console.WriteLine(num1);
            //Console.WriteLine(num2);

            int acarreo = 0;
            string sum = "";

            for (int i = maxLen - 1; i >= 0; i--)
            {
                int actual = (num1[i] - '0') + (num2[i] - '0') + acarreo;
                if (actual > 9)
                {
                    sum = (actual % 10) + "" + sum;
                    acarreo = (actual / 10) % 10;
                }
                else
                {
                    sum = actual + "" + sum;
                    acarreo = 0;
                }
            }

            if (acarreo > 0)
            {
                sum = acarreo + "" + sum;
            }

            return sum;

        }

        static void Main(string[] args)
        {

            //string a = "123";

            //Console.WriteLine(  (a[0] - '0') + 55);

            string a = "584";
            string b =  "18";
            //----------------
                      //602

            Console.WriteLine(AddStrings(a,b));  //602



            Console.ReadLine();

        }
    }
}
