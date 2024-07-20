using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class _1491_Average_Salary
    {

        public double Average(int[] salary)
        {
            int min = salary.Min();
            int max = salary.Max();

            double sum = 0;
            double cont = 0;

            for(int i = 0; i < salary.Length; i++)
            {
                if (salary[i] != min && salary[i] != max)
                {
                    sum += salary[i];
                    cont++;
                }
            }

            return sum / cont ;
        }



    }
}
