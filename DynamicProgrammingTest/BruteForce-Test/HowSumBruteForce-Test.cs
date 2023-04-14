namespace DynamicProgramming.BruteForce_Test
{
    public class HowSumBruteForce_Test
    {
        [Fact]
        public void HowSum_TargetSumZeroTest()
        {
            var result = Sum.HowSum(0, new int[] { 1, 2, 3 });
            Assert.Equal(result, new List<int>());

            result = Sum.HowSum(0, new int[] { 0, 0, 0 });
            Assert.Equal(result, new List<int>());
        }

        [Fact]
        public void HowSum_TargetSumNegativeTest()
        {
            var result = Sum.HowSum(-1, new int[] { 0 });
            Assert.Null(result);

            result = Sum.HowSum(-1, new int[] { 0, -1 });
            Assert.Null(result);
        }

        [Fact]
        public void HowSum_NumbersAreEmptyOrNullTest()
        {
            var result = Sum.HowSum(0, Array.Empty<int>());
            Assert.Equal(result, new List<int>());

            result = Sum.HowSum(1, Array.Empty<int>());
            Assert.Equal(result, new List<int>());

            result = Sum.HowSum(0, null);
            Assert.Equal(result, new List<int>());

            result = Sum.HowSum(1, null);
            Assert.Equal(result, new List<int>());
        }

        [Theory]
        [InlineData(7, new int[] { 2, 3 }, new int[] { 3, 2, 2 })]
        [InlineData(7, new int[] { 5, 3, 4, 7 }, new int[] { 4, 3 })]
        [InlineData(7, new int[] { 2, 4 }, null)]
        [InlineData(8, new int[] { 2, 3, 5 }, new int[] { 2, 2, 2, 2 })]
        public void HowSum_CalculateMultipleTest(int m, int[] nums, int[] expected)
        {
            var result = Sum.HowSum(m, nums);
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
