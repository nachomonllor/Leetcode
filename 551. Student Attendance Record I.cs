
https://leetcode.com/problems/student-attendance-record-i/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        public static bool CheckRecord(string s)
        {
            int A = 0;

            if (s.Contains("LLL")) return false;

            for(int i =0; i<s.Length; i++)
            {
                if (s[i] == 'A') A++;
                if (A > 1) return false;
            }
            return true;
        }

        static void Main(string[] args)
        {

            string Input = "PPALLP";

            Console.WriteLine(CheckRecord(Input));

            Console.ReadLine();
        }
    }
}

