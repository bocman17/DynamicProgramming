namespace DynamicProgrammingTest.Tabulation_Test
{
    public class HowSumTabulation_Test
    {
        [Fact]
        public void HowSumTab_TargetSumZeroTest()
        {
            var result = Sum_Tabulation.HowSumTab(0, new int[] { 1, 2, 3 });
            Assert.Equal(result, new List<int>());

            result = Sum_Tabulation.HowSumTab(0, new int[] { 0, 0, 0 });
            Assert.Equal(result, new List<int>());
        }

        [Fact]
        public void HowSumTab_TargetSumNegativeTest()
        {
            var result = Sum_Tabulation.HowSumTab(-1, new int[] { 0 });
            Assert.Null(result);

            result = Sum_Tabulation.HowSumTab(-1, new int[] { 0, -1 });
            Assert.Null(result);
        }

        [Fact]
        public void HowSumTab_NumbersAreEmptyOrNullTest()
        {
            var result = Sum_Tabulation.HowSumTab(0, Array.Empty<int>());
            Assert.Equal(result, new List<int>());

            result = Sum_Tabulation.HowSumTab(1, Array.Empty<int>());
            Assert.Equal(result, new List<int>());

            result = Sum_Tabulation.HowSumTab(0, null);
            Assert.Equal(result, new List<int>());

            result = Sum_Tabulation.HowSumTab(1, null);
            Assert.Equal(result, new List<int>());
        }

        [Theory]
        [InlineData(7, new int[] { 2, 3 }, new int[] { 3, 2, 2 })]
        [InlineData(7, new int[] { 5, 3, 4, 7 }, new int[] { 4, 3 })]
        [InlineData(7, new int[] { 2, 4 }, null)]
        [InlineData(8, new int[] { 2, 3, 5 }, new int[] { 2, 2, 2, 2 })]
        [InlineData(300, new int[] { 7, 14 }, null)]

        public void HowSumTab_CalculateMultipleTest(int m, int[] nums, int[] expected)
        {
            var result = Sum_Tabulation.HowSumTab(m, nums);
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
