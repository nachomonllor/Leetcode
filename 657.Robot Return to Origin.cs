https://leetcode.com/problems/robot-return-to-origin/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {


        public bool JudgeCircle(string moves)
        {
            int R = 0, L = 0, U = 0, D = 0;
            for (int i = 0; i < moves.Length; i++)
            {
                if (moves[i] == 'R')
                {
                    R++;
                }
                if (moves[i] == 'L')
                {
                    L++;
                }
                if (moves[i] == 'U')
                {
                    U++;
                }
                if (moves[i] == 'D')
                {
                    D++;
                }
            }

            return R == L && U == D;
        }

        static void Main(string[] args)
        {
           


            Console.ReadLine();
        }
    }
}
