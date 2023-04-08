using DynamicProgramming.Memoization;
using Xunit;

namespace DynamicProgrammingTest
{
    public class CanSumMemo_Test
    {
        [Fact]
        public void CanSumMemo_BaseTest()
        {
            var result = Sum_Memo.CanSumMemo(0, Array.Empty<int>());
            Assert.False(result);

            result = Sum_Memo.CanSumMemo(0, null);
            Assert.False(result);
        }

        [Fact]
        public void CanSumMemo_TargetSumZeroTest()
        {
            var result = Sum_Memo.CanSumMemo(0, new int[] {0});
            Assert.True(result);

            result = Sum_Memo.CanSumMemo(0, new int[] { 0, 0, 0});
            Assert.True(result);
        }

        [Fact]
        public void CanSumMemo_TargetSumNegativeTest()
        {
            var result = Sum_Memo.CanSumMemo(-1, new int[] { 0 });
            Assert.False(result);

            result = Sum_Memo.CanSumMemo(-1, new int[] { 0, -1 });
            Assert.False(result);
        }

        [Theory]
        [InlineData( 7, new int[] { 2, 4})]
        [InlineData( 300, new int[] { 7, 14})]

        public void CanSumMemo_CalculateFalseTest(int m, int[] nums )
        {
            var result = Sum_Memo.CanSumMemo(m , nums);
            Assert.False(result);
        }

        [Theory]
        [InlineData(7, new int[] { 2, 3 })]
        [InlineData(8, new int[] { 2, 3, 5 })]

        public void CanSumMemo_CalculateTrueTest(int m, int[] nums)
        {
            var result = Sum_Memo.CanSumMemo(m, nums);
            Assert.True(result);
        }
    }
}