https://leetcode.com/problems/merge-intervals/description/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp108
{
    class Program
    {


        public class Interval
        {
            public int start;
            public int end;
            public Interval() { start = 0; end = 0; }
            public Interval(int s, int e) { start = s; end = e; }
        }


        private static void quicksort(IList<Interval> vector, int primero, int ultimo)
        {
            int i, j, central;
            int pivote;
            central = (primero + ultimo) / 2;
            pivote = vector[central].start;
            i = primero;
            j = ultimo;
            do
            {
                while (vector[i].start < pivote) i++;
                while (vector[j].start > pivote) j--;
                if (i <= j)
                {
                    Interval temp;
                    temp = vector[i];
                    vector[i] = vector[j];
                    vector[j] = temp;
                    // vector.Set(i, vector.get(j));
                    // vector.set(j, temp);

                    i++;
                    j--;
                }
            } while (i <= j);

            if (primero < j)
            {
                quicksort(vector, primero, j);
            }
            if (i < ultimo)
            {
                quicksort(vector, i, ultimo);
            }
        }




        public static IList<Interval> Merge(IList<Interval> intervals)
        {

            if (intervals == null || intervals.Count == 0) return intervals;

            quicksort(intervals, 0, intervals.Count - 1);

            int i = 0;

            List<Interval> res = new List<Interval>();

            while(i < intervals.Count)
            {
                Interval a = intervals[i];
                Interval insertar = a;
                while (i +1 < intervals.Count && intervals[i+1].start <= a.end)
                {

                    insertar = new Interval(Math.Min( a.start, intervals[i+1].start) , Math.Max(a.end, intervals[i + 1].end));
                    a = insertar;
                    i++;
                }
                res.Add(insertar);
                i++;
            }

            return res;
        }

        static void Main(string[] args)
        {

            List<Interval> inter = new List<Interval>();

            //inter.Add(new Interval(1, 3));
            //inter.Add(new Interval(2, 6));
            //inter.Add(new Interval(8, 10));
            //inter.Add(new Interval(15, 18));
            //[1,6],[8,10],[15,18]

            //inter.Add(new Interval(1, 5));
            //inter.Add(new Interval(1, 4));

            inter.Add(new Interval( 1,4));
            inter.Add(new Interval(0, 2));
            inter.Add(new Interval (3,5));
           // [[0,5]]

            
            //quicksort(inter, 0, inter.Count - 1);
            //foreach (Interval elem in inter)
            //{
            //    Console.WriteLine(elem.start + " " + elem.end);
            //}


            //foreach(Interval elem in inter)
            //{
            //    Console.WriteLine(elem.start + " " + elem.end);
            //}
            IList<Interval> res = Merge(inter);

            foreach (Interval elem in res)
            {
                Console.WriteLine(elem.start + " " + elem.end);
            }


            Console.ReadLine();
        }

    }
}
