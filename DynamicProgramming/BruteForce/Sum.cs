namespace DynamicProgramming.BruteForce
{
    public class Sum
    {
        public static bool CanSum(int targetSum, int[]? numbers)
        {
            if (numbers is null || numbers.Length == 0 || targetSum < 0)
            {
                return false;
            }
            if (targetSum == 0) return true;

            for (int i = 0; i < numbers.Length; i++)
            {
                int remainder = targetSum - numbers[i];
                if (CanSum(remainder, numbers))
                {
                    return true;
                };
            }
            return false;
        }

        public static List<int>? HowSum(int targetSum, int[]? numbers)
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

            for (int i = 0; i < numbers.Length; i++)
            {
                int remainder = targetSum - numbers[i];
                var remainderResult = HowSum(remainder, numbers);
                if (remainderResult != null)
                {
                    remainderResult.Add(numbers[i]);
                    return remainderResult;
                }
            }
            return null;
        }

        public static List<int>? BestSum(int targetSum, int[]? numbers)
        {
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
                var remainderCombination = BestSum(remainder, numbers);

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
            return shortestComb;
        }
    }
}
