using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming.Tabulation
{
    public static class Fibonacci_Tabulation
    {
        public static long FibTab(int n)
        {
            if (n is 0) return 0;
            if (n is 1 or 2) return 1;

            long first = 1;
            long second = 1;

            for (int i = 3; i < n; i++)
            {
                (first, second) = (second, first + second);
            }

            return first + second;

            //long[] table = new long[n + 1];

            //table[1] = 1;

            //for (int i = 0; i <= n; i++)
            //{
            //    if (i < n - 1)
            //    {
            //        table[i + 1] += table[i];
            //        table[i + 2] += table[i];
            //    }
            //    else if (i == n - 1)
            //    {
            //        table[i + 1] += table[i];
            //    }
            //}

            //return table[n];
        }
    }
}
