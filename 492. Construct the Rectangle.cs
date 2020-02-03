https://leetcode.com/problems/construct-the-rectangle/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {


        public static int[] ConstructRectangle(int area)
        {

            int sqr = (int) Math.Sqrt(area);


            if (sqr * sqr == area)
            {
                return new int[] { sqr, sqr };
            }


            int ceil = (int)Math.Ceiling(Math.Sqrt(area));
            int floor = (int)Math.Floor(Math.Sqrt(area));

            while ((area / ceil) * ceil < area)
            {
                ceil++;
            }

            int[] res = { area / ceil, ceil };
            Array.Sort(res);
            Array.Reverse(res);

            return res;
        }



        static void Main(string[] args)
        {

            int[] res = ConstructRectangle(37);

            Console.WriteLine(res[0] + " " + res[1]);


            Console.ReadLine();
        }
    }
}
