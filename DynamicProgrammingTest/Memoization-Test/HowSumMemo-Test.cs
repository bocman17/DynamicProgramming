using DynamicProgramming.Memoization;
using Xunit;

namespace DynamicProgrammingTest
{
    public class HowSum_Test
    {
        [Fact]
        public void HowSumMemo_TargetSumZeroTest()
        {
            var result = Sum_Memo.HowSumMemo(0, new int[] { 1, 2, 3 });
            Assert.Equal(result, new List<int>());

            result = Sum_Memo.HowSumMemo(0, new int[] { 0, 0, 0 });
            Assert.Equal(result, new List<int>());
        }

        [Fact]
        public void HowSumMemo_TargetSumNegativeTest()
        {
            var result = Sum_Memo.HowSumMemo(-1, new int[] { 0 });
            Assert.Null(result);

            result = Sum_Memo.HowSumMemo(-1, new int[] { 0, -1 });
            Assert.Null(result);
        }

        [Fact]
        public void HowSumMemo_NumbersAreEmptyOrNullTest()
        {
            var result = Sum_Memo.HowSumMemo(0, Array.Empty<int>());
            Assert.Equal(result, new List<int>());

            result = Sum_Memo.HowSumMemo(1, Array.Empty<int>());
            Assert.Equal(result, new List<int>());

            result = Sum_Memo.HowSumMemo(0, null);
            Assert.Equal(result, new List<int>());

            result = Sum_Memo.HowSumMemo(1, null);
            Assert.Equal(result, new List<int>());
        }

        [Theory]
        [InlineData(7, new int[] { 2, 3 }, new int[] { 3, 2, 2 })]
        [InlineData(7, new int[] { 5, 3, 4, 7 }, new int[] { 4, 3 })]
        [InlineData(7, new int[] { 2, 4 }, null)]
        [InlineData(8, new int[] { 2, 3, 5 }, new int[] { 2, 2, 2, 2 })]
        [InlineData(300, new int[] { 7, 14 }, null)]

        public void HowSumMemo_CalculateMultipleTest(int m, int[] nums, int[] expected)
        {
            var result = Sum_Memo.HowSumMemo(m, nums);
            if (result is null)
            {
                Assert.Null(result);
            }
            else
            {
                Assert.Equal(result, expected);
            }
        }
    }
}