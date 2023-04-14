namespace DynamicProgramming.BruteForce_Test
{
    public class FibonacciBruteForce_Test
    {
        [Fact]
        public void FibonacciBruteForce_BaseTest()
        {
            var result = Fibonacci.Fib(1);
            Assert.Equal(1, result);

            result = Fibonacci.Fib(2);
            Assert.Equal(1, result);
        }

        [Fact]
        public void FibonacciBruteForce_ZeroTest()
        {
            var result = Fibonacci.Fib(0);
            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData(3, 2)]
        [InlineData(6, 8)]
        [InlineData(7, 13)]
        [InlineData(8, 21)]

        public void FibonacciBruteForce_MultipleExamplesTest(int n, long expected)
        {
            var result = Fibonacci.Fib(n);
            Assert.Equal(expected, result);
        }
    }
}
