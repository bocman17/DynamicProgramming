namespace DynamicProgramming.Memoization
{
    public static class GridTraveler_Memo
    {
        public static long GridTravMemo(int m, int n, Dictionary<string, long>? memo = null)
        {
            memo ??= new();
            string key = m + "," + n;
            if (memo.TryGetValue(key, out _))
            {
                return memo[key];
            }
            if (m == 0 || n == 0)
            {
                return 0;
            }
            if (m == 1 || n == 1)
            {
                return 1;
            }
            memo[key] = GridTravMemo(m - 1, n, memo) + GridTravMemo(m, n - 1, memo);
            return memo[key];
        }
    }
}