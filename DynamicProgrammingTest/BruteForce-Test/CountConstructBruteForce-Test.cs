namespace DynamicProgramming.BruteForce_Test
{
    public class CountConstructBruteForceTest
    {
        [Fact]
        public void CountConstruct_TargetStringIsEmptyTest()
        {
            var result = Construct.CountConstruct("", new string[] { "abc", "def" });
            Assert.Equal(1, result);
        }

        [Fact]
        public void CountConstruct_WordBankIsEmptyTest()
        {
            var result = Construct.CountConstruct("abc", Array.Empty<string>());
            Assert.Equal(0, result);
        }

        [Fact]
        public void CountConstruct_TargetStringAndWordBankIsEmptyTest()
        {
            var result = Construct.CountConstruct("", Array.Empty<string>());
            Assert.Equal(1, result);
        }

        [Theory]
        [InlineData("purple", new string[] { "purp", "p", "ur", "le", "purpl" }, 2)]
        [InlineData("abcdef", new string[] { "ab", "abc", "cd", "def", "abcd" }, 1)]
        [InlineData("skateboard",
            new string[] { "bo", "rd", "ate", "t", "ska", "sk", "boar" }, 0)]
        [InlineData("enterapotentpot",
            new string[] { "a", "p", "ent", "enter", "ot", "o", "t" }, 4)]
        public void CountConstruct_AssertMultipleTest(string target, string[] wordBank, int expected)
        {
            var result = Construct.CountConstruct(target, wordBank);
            Assert.Equal(expected, result);
        }
    }
}
