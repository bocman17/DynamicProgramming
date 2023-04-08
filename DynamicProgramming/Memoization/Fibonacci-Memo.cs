namespace DynamicProgramming.Memoization
{
    public static class Fibonacci_Memo
    {
        public static long FibMemo(int n, Dictionary<int, long>? memo = null)
        {
            memo ??= new() { { 0, 0 }, { 1, 1 } };
            if (memo.TryGetValue(n, out long _))
            {
                return memo[n];
            }
            if (n <= 2)
            {
                return 1;
            }
            memo[n] = FibMemo(n - 1, memo) + FibMemo(n - 2, memo);
            return memo[n];
        }
    }
}