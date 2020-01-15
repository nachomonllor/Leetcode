http://oj.leetcode.com/problems/merge-sorted-array/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public class Solution
        {
             
            public void merge(int[] A, int m, int[] B, int n)
            {
                int[] C = new int[m + n];
                int iA = 0, iB = 0, iC = 0;
                while (iA < m && iB < n)
                {
                    if (A[iA] < B[iB])
                    {
                        C[iC] = A[iA];
                        iA++;
                    }
                    else
                    {
                        C[iC] = B[iB];
                        iB++;
                    }
                    iC++;
                }
                while (iA < m)
                {
                    C[iC] = A[iA];
                    iA++; iC++;
                }
                while (iB < n)
                {
                    C[iC] = B[iB];
                    iB++; iC++;
                }
                iC = 0;
                for (int i = 0; i < m + n; i++)
                {
                    A[i] = C[iC];
                    iC++;
                }
            }
            static void Main(string[] args)
            {
            }
        }
    }
}
