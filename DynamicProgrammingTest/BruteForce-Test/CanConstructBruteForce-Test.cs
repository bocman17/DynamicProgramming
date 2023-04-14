namespace DynamicProgramming.BruteForce_Test
{
    public class CanConstructBruteForce_Test
    {
        [Fact]
        public void CanConstruct_TargetStringIsEmptyTest()
        {
            var result = Construct.CanConstruct("", new string[] { "abc", "def" });
            Assert.True(result);
        }

        [Fact]
        public void CanConstruct_WordBankIsEmptyTest()
        {
            var result = Construct.CanConstruct("abc", Array.Empty<string>());
            Assert.False(result);
        }

        [Fact]
        public void CanConstruct_TargetStringAndWordBankIsEmptyTest()
        {
            var result = Construct.CanConstruct("", Array.Empty<string>());
            Assert.True(result);
        }

        [Theory]
        [InlineData("abcdef", new string[] { "ab", "abc", "cd", "def", "abcd" })]
        [InlineData("enterapotentpot", new string[] { "a", "p", "ent", "enter", "ot", "o", "t" })]
        public void CanConstruct_AssertMultipleTrueTest(string target, string[] wordBank)
        {
            var result = Construct.CanConstruct(target, wordBank);
            Assert.True(result);
        }

        [Theory]
        [InlineData("skateboard", new string[] { "bo", "rd", "ate", "t", "ska", "sk", "boar" })]
        [InlineData("enterapotentpot", new string[] { "e", "p", "ent", "enter", "ot", "o", "t" })]
        public void CanConstruct_AssertMultipleFalseTest(string target, string[] wordBank)
        {
            var result = Construct.CanConstruct(target, wordBank);
            Assert.False(result);
        }
    }
}
