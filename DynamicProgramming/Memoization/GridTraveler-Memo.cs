namespace DynamicProgramming.Memoization
{
    public static class GridTraveler_Memo
    {
        static readonly Dictionary<string, long> _memo = new();

        public static long GridTravMemo(int m, int n)
        {
            string key = m + "," + n;
            if (_memo.TryGetValue(key, out _))
            {
                return _memo[key];
            }
            if (m == 0 || n == 0)
            {
                return 0;
            }
            if (m == 1 || n == 1)
            {
                return 1;
            }
            _memo[key] = GridTravMemo(m - 1, n) + GridTravMemo(m, n - 1);
            return _memo[key];
        }
    }
}