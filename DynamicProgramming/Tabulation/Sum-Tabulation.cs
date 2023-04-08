using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming.Tabulation
{
    public static class Sum_Tabulation
    {
        public static bool CanSumTab(int targetSum, int[] numbers)
        {
            if (targetSum == 0)
            {
                return true;
            }

            bool[] table = new bool[targetSum + 1];
            table[0] = true;
            for (int i = 0; i <= targetSum; i++)
            {
                if (table[i] == true)
                {
                    foreach (var num in numbers)
                    {
                        if (i + num <= targetSum)
                            table[i + num] = true;
                    }
                }
            }
            return table[targetSum];
        }

        public static List<int>? HowSumTab(int targetSum, int[]? numbers)
        {
            if (numbers is null || numbers.Length <= 0)
            {
                return new List<int>();
            }
            if (targetSum == 0)
            {
                return new List<int>();
            }
            if (targetSum < 0)
            {
                return null;
            }

            List<List<int>?> table = new();

            for (int i = 0; i < targetSum; i++)
            {
                if (i == 0)
                {
                    table.Add(new List<int>());
                }
                table.Add(null);
            }

            for (int i = 0; i <= targetSum; i++)
            {
                if (table[i] is not null)
                {
                    foreach (var num in numbers)
                    {
                        if (i + num <= targetSum)
                        {
                            table[i + num] = new List<int>();
                            table[i + num]!.AddRange(table[i]!);
                            table[i + num]!.Add(num);
                        }
                    }
                }
            }

            return table[targetSum];
        }

        public static int[] BestSumTab(int targetSum, int[] numbers)
        {
            if(targetSum <= 0 || numbers.Length <= 0)
            {
                return Array.Empty<int>();
            }
            int[][] table = new int[targetSum + 1][];
            table[0] = Array.Empty<int>(); // base case: empty array for target sum 0

            for (int i = 0; i <= targetSum; i++)
            {
                if (table[i] != null)
                {
                    foreach (int num in numbers)
                    {
                        int[] currentCombination = table[i];
                        int[] newCombination = currentCombination.Concat(new int[] {num}).ToArray();
                        int newSum = i + num;

                        if(newSum <= targetSum && (table[newSum] == null || newCombination.Length < table[newSum].Length))
                        {
                            table[newSum] = newCombination;
                        }
                    }
                }
            }
            return table[targetSum] ?? Array.Empty<int>();
        }
    }
}
