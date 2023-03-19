namespace DynamicProgramming
{
    public static class Fibonacci
    {
        public static long Fib(int n, Dictionary<long, long>? memo = null)
        {
            memo ??= new() { { 0, 0 }, { 1, 1 } };
            if (memo.TryGetValue(n, out long value))
            {
                return value;
            }
            if(n <= 2)
            {
                return 1;
            }
            memo[n] = Fib(n - 1, memo) + Fib(n - 2, memo);
            return memo[n];
        }
    }
}