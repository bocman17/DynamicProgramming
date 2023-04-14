namespace DynamicProgramming.Memoization
{
    public static class Fibonacci_Memo
    {
        static readonly Dictionary<int, long> _memo = new();
        public static long FibMemo(int n)
        {
            if (_memo.TryGetValue(n, out long _))
            {
                return _memo[n];
            }
            if(n == 0)
            {
                return 0;
            }
            if (n <= 2)
            {
                return 1;
            }
            _memo[n] = FibMemo(n - 1) + FibMemo(n - 2);
            return _memo[n];
        }
    }
}