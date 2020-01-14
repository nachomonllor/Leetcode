https://leetcode.com/problems/buddy-strings/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {


        public static bool buddyStrings(string A, string B)
        {

            if (A.Length == 0 || B.Length == 0) return false;

            if (A.Length != B.Length) return false;
            

            int cont = 0;
            List<char> elemA = new List<char>();
            List<char> elemB = new List<char>();



            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] != B[i])
                {
                    cont++;
                    elemA.Add(A[i]);
                    elemB.Add(B[i]);
                }
            }
            if (cont > 2) return false;
            if (A.Length == 2 && B.Length ==2 && A == B && A[0] != A[1])
            {
                return false  ;
            }
            //if(A.Length > 2 && )

           // if (cont == 0) return true;
            elemA.Sort();
            elemB.Sort();

            

            for (int i = 0; i < elemA.Count; i++)
            {
                if (elemA[i] != elemB[i])
                {
                    return false;
                }
            }

            if(A.Length > 2 && A == B)
            {
                Dictionary<char, int> hash =
                    new Dictionary<char, int>();

                for(int i =0; i<A.Length; i++)
                {
                    if(hash.ContainsKey(A[i]))
                    {
                        hash[A[i]]++;
                        if (hash[A[i]] > 1) return true;
                    }
                    else
                    {
                        hash[A[i]] = 1;
                    }
                }

                return false;
            }

            return true;
        }

        static void Main(string[] args)
        {

            //string A = "aaaaaaabc";
            //string B = "aaaaaaacb";

            //string A = "ab"; //false
            //string B = "ab";

            //string A = "aa"; //true
            //string B = "aa";

            //string A = "abcd"; //false
            //string B = "abcd";

            string A = "abab";   //true
            string B = "abab";


            Console.WriteLine(buddyStrings(A, B));

            Console.ReadLine();
        }
    }
}

