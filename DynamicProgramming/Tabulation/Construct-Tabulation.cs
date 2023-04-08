using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming.Tabulation
{
    public static class Construct_Tabulation
    {
        public static bool CanConstructTab(string target, string[] wordBank)
        {
            if (string.IsNullOrEmpty(target)) return true;

            bool[] table = new bool[target.Length + 1];
            table[0] = true;

            for (int i = 0; i <= target.Length; i++)
            {
                if (table[i])
                {
                    for (int j = 0; j < wordBank.Length; j++)
                    {
                        if (target[i..].StartsWith(wordBank[j]) && i + wordBank[j].Length <= target.Length)
                        {
                            table[i + wordBank[j].Length] = true;
                        }
                    }
                }
            }

            return table[target.Length];
        }

        public static int CountConstructTab(string target, string[] wordBank)
        {
            if (string.IsNullOrEmpty(target)) return 1;

            int[] table = new int[target.Length + 1];
            table[0] = 1;

            for (int i = 0; i <= target.Length; i++)
            {
                if (table[i] > 0)
                {
                    foreach (var word in wordBank)
                    {
                        if (target[i..].StartsWith(word) && i + word.Length <= target.Length)
                        {
                            table[i + word.Length] += table[i];
                        }
                    }
                }
            }

            return table[target.Length];
        }

        public static List<List<string>> AllConstructTab(string target, string[] wordBank)
        {
            if(string.IsNullOrEmpty(target))
            {
                return new List<List<string>> { new List<string>() };
            }

            List<List<List<string>>> table = new();
            for (int i = 0; i <= target.Length; i++)
            {
                table.Add(new List<List<string>>());
            }

            table[0].Add(new List<string>());

            for (int i = 0; i <= target.Length; i++)
            {
                foreach (string word in wordBank)
                {
                    if (target[i..].StartsWith(word))
                    {
                        List<List<string>> newCombinations = new();

                        foreach (List<string> combination in table[i])
                        {
                            List<string> newCombination = new(combination)
                            {
                                word
                            };
                            newCombinations.Add(newCombination);
                        }

                        table[i + word.Length].AddRange(newCombinations);
                    }
                }
            }

            return table[target.Length];
        }
    }
}
