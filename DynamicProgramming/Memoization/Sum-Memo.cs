namespace DynamicProgramming.Memoization
{
    public static class Sum_Memo
    {
        public static bool CanSumMemo(int targetSum, int[]? numbers, Dictionary<int, bool>? memo = null)
        {
            memo ??= new Dictionary<int, bool>();
            if (memo.TryGetValue(targetSum, out _))
            {
                return memo[targetSum];
            }
            if (numbers is null || numbers.Length == 0)
            {
                return false;
            }
            if (targetSum == 0) return true;

            for (int i = 0; i < numbers.Length; i++)
            {
                int remainder = targetSum - numbers[i];
                if (CanSumMemo(remainder, numbers, memo))
                {
                    memo[targetSum] = true;
                    return true;
                };
            }
            memo[targetSum] = false;
            return false;
        }

        public static List<int>? HowSumMemo(int targetSum, int[]? numbers, Dictionary<int, List<int>?>? memo = null)
        {
            memo ??= new Dictionary<int, List<int>?>();
            if (memo.TryGetValue(targetSum, out _))
            {
                return memo[targetSum];
            }
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

            for (int i = 0; i < numbers.Length; i++)
            {
                int remainder = targetSum - numbers[i];
                var remainderResult = HowSumMemo(remainder, numbers, memo);
                if (remainderResult != null)
                {
                    remainderResult.Add(numbers[i]);
                    memo[targetSum] = remainderResult;
                    return memo[targetSum];
                }
            }

            memo[targetSum] = null;
            return null;
        }

        public static List<int>? BestSumMemo(int targetSum, int[]? numbers, Dictionary<int, List<int>?>? memo = null)
        {
            memo ??= new Dictionary<int, List<int>?>();
            if (memo.TryGetValue(targetSum, out _))
            {
                return memo[targetSum];
            }
            List<int>? shortestComb = null;
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
            for (int i = 0; i < numbers.Length; i++)
            {
                int remainder = targetSum - numbers[i];
                var remainderCombination = BestSumMemo(remainder, numbers, memo);

                if (remainderCombination is not null)
                {
                    var combination = new List<int>(remainderCombination)
                    {
                        numbers[i]
                    };

                    if (shortestComb is null || combination.Count < shortestComb.Count)
                    {
                        shortestComb = combination;
                    }
                }
            }
            memo[targetSum] = shortestComb;
            return shortestComb;
        }
    }
}