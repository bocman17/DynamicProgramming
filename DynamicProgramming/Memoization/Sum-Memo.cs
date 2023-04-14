namespace DynamicProgramming.Memoization
{
    public static class Sum_Memo
    {
        public static bool CanSumMemo(int targetSum, int[] numbers)
        {
            Dictionary<int, bool> memo = new();
            return CanSum(targetSum, numbers, memo);
        }
        private static bool CanSum(int targetSum, int[] numbers, Dictionary<int, bool> memo)
        {
            if (memo.TryGetValue(targetSum, out bool value))
            {
                return value;
            }
            if (targetSum == 0)
            {
                return true;
            }
            if (targetSum < 0)
            {
                return false;
            }

            foreach (int num in numbers)
            {
                int remainder = targetSum - num;
                if (CanSum(remainder, numbers, memo))
                {
                    memo[targetSum] = true;
                    return true;
                }
            }

            memo[targetSum] = false;
            return false;
        }
        public static List<int>? HowSumMemo(int targetSum, int[] numbers)
        {
            Dictionary<int, List<int>?>? memo = new();
            return HowSum(targetSum, numbers, memo);
        }
        private static List<int>? HowSum(int targetSum, int[]? numbers, Dictionary<int, List<int>?>? memo)
        {
            if (memo is not null)
            {
                if (memo.TryGetValue(targetSum, out _))
                {
                    return memo[targetSum];
                }
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
                var remainderResult = HowSum(remainder, numbers, memo);
                if (remainderResult != null)
                {
                    remainderResult.Add(numbers[i]);
                    if (memo is not null)
                    {
                        memo[targetSum] = remainderResult;
                        return memo[targetSum];
                    }
                }
            }
            if (memo is not null)
            {
                memo[targetSum] = null;
            }
            return null;
        }

        public static List<int>? BestSumMemo(int targetSum, int[] numbers)
        {
            Dictionary<int, List<int>?>? memo = new();
            return BestSum(targetSum, numbers, memo);
        }
        private static List<int>? BestSum(int targetSum, int[]? numbers, Dictionary<int, List<int>?>? memo = null)
        {
            if (memo is not null)
            {
                if (memo.TryGetValue(targetSum, out _))
                {
                    return memo[targetSum];
                }
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
                var remainderCombination = BestSum(remainder, numbers, memo);

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
            if (memo is not null)
            {
                memo[targetSum] = shortestComb;
            }
            return shortestComb;
        }
    }
}