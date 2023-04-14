namespace DynamicProgramming.Tabulation_Test
{
    public class GridTravelerTabulation_Test
    {
        [Fact]
        public void GridTravelerTab_BaseTest()
        {
            var result = GridTraveler_Tabulation.GridTravTab(1, 1);
            Assert.Equal(1, result);

            result = GridTraveler_Tabulation.GridTravTab(2, 1);
            Assert.Equal(1, result);

            result = GridTraveler_Tabulation.GridTravTab(1, 2);
            Assert.Equal(1, result);
        }

        [Fact]
        public void GridTravelerTab_ZeroTest()
        {
            var result = GridTraveler_Tabulation.GridTravTab(0, 0);
            Assert.Equal(0, result);

            result = GridTraveler_Tabulation.GridTravTab(0, 1);
            Assert.Equal(0, result);

            result = GridTraveler_Tabulation.GridTravTab(1, 0);
            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData(2, 3, 3)]
        [InlineData(3, 2, 3)]
        [InlineData(3, 3, 6)]
        [InlineData(18, 18, 2333606220)]

        public void GridTravelerTab_MultipleExamplesTest(int m, int n, long expected)
        {
            var result = GridTraveler_Tabulation.GridTravTab(m, n);
            Assert.Equal(expected, result);
        }
    }
}
