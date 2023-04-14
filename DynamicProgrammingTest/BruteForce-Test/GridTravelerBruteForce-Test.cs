namespace DynamicProgramming.BruteForce_Test
{
    public class GridTravelerBruteForce_Test
    {
        [Fact]
        public void GridTravelerBruteForce_BaseTest()
        {
            var result = GridTraveler.GridTrav(1, 1);
            Assert.Equal(1, result);

            result = GridTraveler.GridTrav(2, 1);
            Assert.Equal(1, result);

            result = GridTraveler.GridTrav(1, 2);
            Assert.Equal(1, result);
        }

        [Fact]
        public void GridTravelerBruteForce_ZeroTest()
        {
            var result = GridTraveler.GridTrav(0, 0);
            Assert.Equal(0, result);

            result = GridTraveler.GridTrav(0, 1);
            Assert.Equal(0, result);

            result = GridTraveler.GridTrav(1, 0);
            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData(2, 3, 3)]
        [InlineData(3, 2, 3)]
        [InlineData(3, 3, 6)]

        public void GridTravelerBruteForce_MultipleExamplesTest(int m, int n, long expected)
        {
            var result = GridTraveler.GridTrav(m, n);
            Assert.Equal(expected, result);
        }
    }
}
