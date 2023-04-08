using DynamicProgramming.Memoization;
using Xunit;

namespace DynamicProgrammingTest
{
    public class GridTraveler_Test
    {
        [Fact]
        public void GridTravelerMemo_BaseTest()
        {
            var result = GridTraveler_Memo.GridTravMemo(1, 1);
            Assert.Equal(1, result);

            result = GridTraveler_Memo.GridTravMemo(2, 1);
            Assert.Equal(1, result);

            result = GridTraveler_Memo.GridTravMemo(1, 2);
            Assert.Equal(1, result);
        }

        [Fact]
        public void GridTravelerMemo_ZeroTest()
        {
            var result = GridTraveler_Memo.GridTravMemo(0, 0);
            Assert.Equal(0, result);

            result = GridTraveler_Memo.GridTravMemo(0, 1);
            Assert.Equal(0, result);

            result = GridTraveler_Memo.GridTravMemo(1, 0);
            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData( 2, 3, 3)]
        [InlineData( 3, 2, 3)]
        [InlineData( 3, 3, 6)]
        [InlineData( 18, 18, 2333606220)]

        public void GridTravelerMemo_MultipleExamplesTest(int m, int n, long expected)
        {
            var result = GridTraveler_Memo.GridTravMemo(m , n);
            Assert.Equal(expected, result);
        }
    }
}