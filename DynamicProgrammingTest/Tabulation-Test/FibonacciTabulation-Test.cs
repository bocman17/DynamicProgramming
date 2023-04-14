namespace DynamicProgramming.Tabulation_Test
{
    public class FibonacciTabulation_Test
    {
        [Fact]
        public void FibonacciTab_BaseTest()
        {
            var result = Fibonacci_Tabulation.FibTab(1);
            Assert.Equal(1, result);

            result = Fibonacci_Tabulation.FibTab(2);
            Assert.Equal(1, result);
        }

        [Fact]
        public void FibonacciTab_ZeroTest()
        {
            var result = Fibonacci_Tabulation.FibTab(0);
            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData(3, 2)]
        [InlineData(6, 8)]
        [InlineData(7, 13)]
        [InlineData(8, 21)]
        [InlineData(50, 12586269025)]

        public void FibonacciTab_MultipleExamplesTest(int n, long expected)
        {
            var result = Fibonacci_Tabulation.FibTab(n);
            Assert.Equal(expected, result);
        }
    }
}
