namespace DynamicProgramming.BruteForce_Test
{
    public class CanSumBruteForce_Test
    {
        [Fact]
        public void CanSum_BaseTest()
        {
            var result = Sum.CanSum(0, Array.Empty<int>());
            Assert.False(result);

            result = Sum.CanSum(0, null);
            Assert.False(result);
        }

        [Fact]
        public void CanSum_TargetSumZeroTest()
        {
            var result = Sum.CanSum(0, new int[] { 0 });
            Assert.True(result);

            result = Sum.CanSum(0, new int[] { 0, 0, 0 });
            Assert.True(result);
        }

        [Theory]
        [InlineData(7, new int[] { 2, 4 })]
        [InlineData(11, new int[] { 6, 4 })]
        public void CanSum_CalculateFalseTest(int m, int[] nums)
        {
            var result = Sum.CanSum(m, nums);
            Assert.False(result);
        }

        [Theory]
        [InlineData(7, new int[] { 2, 3 })]
        [InlineData(8, new int[] { 2, 3, 5 })]

        public void CanSum_CalculateTrueTest(int m, int[] nums)
        {
            var result = Sum.CanSum(m, nums);
            Assert.True(result);
        }
    }
}
