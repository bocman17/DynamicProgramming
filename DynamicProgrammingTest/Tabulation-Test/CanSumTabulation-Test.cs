namespace DynamicProgrammingTest.Tabulation_Test
{
    public class CanSumTabulation
    {
        [Fact]
        public void CanSumTab_ZeroTest()
        {
            var result = Sum_Tabulation.CanSumTab(0, Array.Empty<int>());
            Assert.True(result);

            result = Sum_Tabulation.CanSumTab(0, new int[] { 1, 2, 3});
            Assert.True(result);

            result = Sum_Tabulation.CanSumTab(0, new int[] { 0 });
            Assert.True(result);

            result = Sum_Tabulation.CanSumTab(0, new int[] { 0, 0, 0 });
            Assert.True(result);
        }

        [Theory]
        [InlineData(7, new int[] { 2, 4 })]
        [InlineData(300, new int[] { 7, 14 })]

        public void CanSumTab_CalculateFalseTest(int m, int[] nums)
        {
            var result = Sum_Tabulation.CanSumTab(m, nums);
            Assert.False(result);
        }

        [Theory]
        [InlineData(7, new int[] { 2, 3 })]
        [InlineData(8, new int[] { 2, 3, 5 })]

        public void CanSumTab_CalculateTrueTest(int m, int[] nums)
        {
            var result = Sum_Tabulation.CanSumTab(m, nums);
            Assert.True(result);
        }
    }
}
