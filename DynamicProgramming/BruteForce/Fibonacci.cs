namespace DynamicProgramming.BruteForce
{
    public class Fibonacci
    {
        public static long Fib(int n)
        {
            if( n <= 0)
            {
                return 0;
            }   
            if (n <= 2)
            {
                return 1;
            }
            return Fib(n - 1) + Fib(n - 2);
        }
    }
}
