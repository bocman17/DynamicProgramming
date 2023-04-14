namespace DynamicProgramming.BruteForce
{
    public class GridTraveler
    {
        public static long GridTrav(int m, int n)
        {
            if (m == 0 || n == 0)
            {
                return 0;
            }
            if (m == 1 || n == 1)
            {
                return 1;
            }
            return GridTrav(m - 1, n) + GridTrav(m, n - 1);
        }
    }
}
