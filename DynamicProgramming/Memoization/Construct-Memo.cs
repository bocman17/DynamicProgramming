
namespace DynamicProgramming
{
    public static class Construct_Memo
    {
        public static bool CanConstructMemo(string target, string[] wordBank)
        {
            Dictionary<string, bool> memo = new();
            return CanConstruct(target, wordBank, memo);
        }
        private static bool CanConstruct(string target, string[] wordBank, Dictionary<string, bool> memo)
        {
            if (memo.TryGetValue(target, out _))
            {
                return memo[target];
            }
            if (target == "")
            {
                return true;
            }

            for (int i = 0; i < wordBank.Length; i++)
            {
                if (target.IndexOf(wordBank[i]) == 0)
                {
                    string suffix = target[wordBank[i].Length..];
                    if (CanConstruct(suffix, wordBank, memo))
                    {
                        memo[target] = true;
                        return true;
                    }
                }
            }
            memo[target] = false;
            return false;
        }

        public static int CountConstructMemo(string target, string[] wordBank)
        {
            Dictionary<string, int> memo = new();
            return CountConstruct(target, wordBank, memo);
        }
        private static int CountConstruct(string target, string[] wordBank, Dictionary<string, int>? memo = null)
        {
            if (memo is not null)
            {
                if (memo.TryGetValue(target, out _))
                {
                    return memo[target];
                }
            }

            if (target == "")
            {
                return 1;
            }

            int totalCount = 0;

            for (int i = 0; i < wordBank.Length; i++)
            {
                if (target.IndexOf(wordBank[i]) == 0)
                {
                    int numWaysForRest = CountConstruct(target[wordBank[i].Length..], wordBank, memo);
                    totalCount += numWaysForRest;
                }
            }
            if (memo is not null)
            {
                memo[target] = totalCount;
            }
            return totalCount;
        }

        public static List<List<string>> AllConstructMemo(string target, string[] wordBank)
        {
            Dictionary<string, List<List<string>>>? memo = new();
            return AllConstruct(target, wordBank, memo);
        }

        private static List<List<string>> AllConstruct(string target, string[] wordBank,
            Dictionary<string, List<List<string>>>? memo = null)
        {
            memo ??= new Dictionary<string, List<List<string>>>();
            if (memo.TryGetValue(target, out _))
            {
                return memo[target];
            }

            if (string.IsNullOrEmpty(target))
            {
                return new List<List<string>> { new List<string>() };
            }

            List<List<string>> result = new();

            foreach (string word in wordBank)
            {
                if (target.StartsWith(word))
                {
                    string suffix = target[word.Length..];
                    List<List<string>> suffixWays = AllConstruct(suffix, wordBank, memo);
                    List<List<string>> targetWays = new();

                    foreach (List<string> way in suffixWays)
                    {
                        List<string> newWay = new(way);
                        newWay.Insert(0, word);
                        targetWays.Add(newWay);
                    }

                    result.AddRange(targetWays);
                }
            }
            memo[target] = result;
            return result;
        }
    }
}
