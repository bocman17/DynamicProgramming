namespace DynamicProgrammingTest.Tabulation_Test
{
    public class BestSumTabulation_Test
    {
        [Fact]
        public void BestSumTab_TargetSumZeroTest()
        {
            var result = Sum_Tabulation.BestSumTab(0, new int[] { 1, 2, 3 });
            Assert.Equal(result, Array.Empty<int>());

            result = Sum_Tabulation.BestSumTab(0, new int[] { 0, 0, 0 });
            Assert.Equal(result, Array.Empty<int>());
        }

        [Fact]
        public void BestSumTab_TargetSumNegativeTest()
        {
            var result = Sum_Tabulation.BestSumTab(-1, new int[] { 0 });
            Assert.Equal(result, Array.Empty<int>());

            result = Sum_Tabulation.BestSumTab(-1, new int[] { 0, -1 });
            Assert.Equal(result, Array.Empty<int>());
        }

        [Fact]
        public void BestSumTab_NumbersAreEmptyTest()
        {
            var result = Sum_Tabulation.BestSumTab(0, Array.Empty<int>());
            Assert.Equal(result, Array.Empty<int>());

            result = Sum_Tabulation.BestSumTab(1, Array.Empty<int>());
            Assert.Equal(result, Array.Empty<int>());
        }

        [Theory]
        [InlineData(7, new int[] { 5, 3, 4, 7 }, new int[] { 7 })]
        [InlineData(8, new int[] { 2, 3, 5 }, new int[] { 3, 5 })]
        [InlineData(8, new int[] { 1, 4, 5 }, new int[] { 4, 4 })]
        [InlineData(100, new int[] { 1, 2, 5, 25 }, new int[] { 25, 25, 25, 25 })]
        [InlineData(300, new int[] { 7, 14 }, new int[] { })]

        public void BestSumTab_CalculateMultipleTest(int m, int[] nums, int[] expected)
        {
            var result = Sum_Tabulation.BestSumTab(m, nums);
            Assert.Equal(result, expected);
        }

    }
}
