using DynamicProgramming.Memoization;
using Xunit;

namespace DynamicProgrammingTest
{
    public class FibonacciMemo_Test
    {
        [Fact]
        public void FibonacciMemo_BaseTest()
        {
            var result = Fibonacci_Memo.FibMemo(1);
            Assert.Equal(1, result);

            result = Fibonacci_Memo.FibMemo(2);
            Assert.Equal(1, result);
        }

        [Fact]
        public void FibonacciMemo_ZeroTest()
        {
            var result = Fibonacci_Memo.FibMemo(0);
            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData( 3, 2)]
        [InlineData( 6, 8)]
        [InlineData( 7, 13)]
        [InlineData( 8, 21)]
        [InlineData( 50, 12586269025)]

        public void FibonacciMemo_MultipleExamplesTest(int n, long expected)
        {
            var result = Fibonacci_Memo.FibMemo(n);
            Assert.Equal(expected, result);
        }
    }
}