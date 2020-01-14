https://leetcode.com/problems/long-pressed-name/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static List<string > Contar(string s)
        {
            List<string> cuenta = new List<string>();

            char pre = s[0];
            int cont = 0;
            for (int i = 0; i < s.Length; i++) 
            {
                if (s[i] == pre)
                {
                    cont++;
                }
                else
                {
                    cuenta.Add(pre + " " + cont);
                    cont = 1;
                    pre = s[i];
                }
            }

            if (cont > 0) cuenta.Add(pre + " " + cont);
            
            return cuenta;
        }

        public static bool IsLongPressedName(string name, string typed)
        {
            if (typed.Length < name.Length) return false;

            List<string> cuentaName = Contar(name);
            List<string> cuentaTyped = Contar(typed);

            if (cuentaName.Count != cuentaTyped.Count) return false;

            for(int i =0; i<cuentaName.Count; i++)
            {
                if(cuentaName[i].Split(' ')[0] != cuentaTyped[i].Split(' ')[0])
                {
                    return false;
                }

                if (int.Parse( cuentaName[i].Split(' ')[1]) > int.Parse( cuentaTyped[i].Split(' ')[1]))
                {
                    return false;
                }
            }

            return true;

        }

        static void Main(string[] args)
        {
            //string name = "leelee";
            //string typed = "lleeelee";

            string name = "saeed";
            string typed = "ssaaedd";

            Console.WriteLine( IsLongPressedName(name, typed));

            Console.ReadLine();
        }
    }
}
