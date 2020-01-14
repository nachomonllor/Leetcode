https://www.hackerrank.com/challenges/strong-password/problem
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        static int minimumNumber(int n, string password)
        {

            // Return the minimum number of characters to make the password strong
            HashSet<char> numbers = new HashSet<char>("0123456789".ToCharArray());
            HashSet<char> lower_case = new HashSet<char>("abcdefghijklmnopqrstuvwxyz".ToCharArray());
            HashSet<char> upper_case = new HashSet<char>("ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray());
            HashSet<char> special_characters = new HashSet<char>("!@#$%^&*()-+".ToCharArray());


            bool flag_num = false;
            bool flag_lower = false;
            bool flag_upper = false;
            bool flag_special = false;


            for (int i = 0; i < password.Length; i++)
            {
                if (numbers.Contains(password[i]))
                {
                    flag_num = true;
                }
                if (lower_case.Contains(password[i]))
                {
                    flag_lower = true;
                }
                if (upper_case.Contains(password[i]))
                {
                    flag_upper = true;
                }
                if (special_characters.Contains(password[i]))
                {
                    flag_special = true;
                }
            }

            int faltan = 0;
            if (!flag_num) faltan++;
            if (!flag_lower) faltan++;
            if (!flag_special) faltan++;
            if (!flag_upper) faltan++;

            if (n < 6)
            {
                return Math.Max( (6 - n), faltan);
            }


            return faltan;
        }




       


        static void Main(string[] args)
        {

            string s = "Ab1";


            Console.WriteLine(minimumNumber(3, s));

            Console.ReadLine();
        }
    }
}
