using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming.Tabulation
{
    public static class GridTraveler_Tabulation
    {
        public static long GridTravTab(int m, int n)
        {
            if (m == 0 || n == 0)
            {
                return 0;
            }

            if (m == 1 || n == 1)
            {
                return 1;
            }

            long[,] tab = new long[m + 1, n + 1];

            tab[1, 1] = 1;

            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    long current = tab[i, j];
                    if (i > 0 && i < m)
                    {
                        tab[i + 1, j] += current;
                    }
                    if (j > 0 && j < n)
                    {
                        tab[i, j + 1] += current;
                    }
                }
            }

            return tab[m, n];
        }
    }
}
