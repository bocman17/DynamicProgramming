namespace DynamicProgramming.Memoization_Test
{
    public class BestSumMemo_Test
    {
        [Fact]
        public void BestSumMemo_TargetSumZeroTest()
        {
            var result = Sum_Memo.BestSumMemo(0, new int[] { 1, 2, 3 });
            Assert.Equal(result, new List<int>());

            result = Sum_Memo.BestSumMemo(0, new int[] { 0, 0, 0 });
            Assert.Equal(result, new List<int>());
        }

        [Fact]
        public void BestSumMemo_TargetSumNegativeTest()
        {
            var result = Sum_Memo.BestSumMemo(-1, new int[] { 0 });
            Assert.Null(result);

            result = Sum_Memo.BestSumMemo(-1, new int[] { 0, -1 });
            Assert.Null(result);
        }

        [Fact]
        public void BestSumMemo_NumbersAreEmptyOrNullTest()
        {
            var result = Sum_Memo.BestSumMemo(0, Array.Empty<int>());
            Assert.Equal(result, new List<int>());

            result = Sum_Memo.BestSumMemo(1, Array.Empty<int>());
            Assert.Equal(result, new List<int>());

            result = Sum_Memo.BestSumMemo(0, null);
            Assert.Equal(result, new List<int>());

            result = Sum_Memo.BestSumMemo(1, null);
            Assert.Equal(result, new List<int>());
        }

        [Theory]
        [InlineData(7, new int[] { 5, 3, 4, 7 }, new int[] { 7 })]
        [InlineData(8, new int[] { 2, 3, 5 }, new int[] { 5, 3 })]
        [InlineData(8, new int[] { 1, 4, 5 }, new int[] { 4, 4 })]
        [InlineData(100, new int[] { 1, 2, 5, 25 }, new int[] { 25, 25, 25, 25 })]
        [InlineData(300, new int[] { 7, 14 }, null)]

        public void BestSumMemo_CalculateMultipleTest(int m, int[] nums, int[] expected)
        {
            var result = Sum_Memo.BestSumMemo(m, nums);
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