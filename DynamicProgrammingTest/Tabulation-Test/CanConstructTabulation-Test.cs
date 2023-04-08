namespace DynamicProgrammingTest.Tabulation_Test
{
    public class CanConstructTabulation
    {
        [Fact]
        public void CanConstructTab_TargetStringIsEmptyTest()
        {
            var result = Construct_Tabulation.CanConstructTab("", new string[] { "abc", "def" });
            Assert.True(result);
        }

        [Fact]
        public void CanConstructTab_WordBankIsEmptyTest()
        {
            var result = Construct_Tabulation.CanConstructTab("abc", Array.Empty<string>());
            Assert.False(result);
        }

        [Fact]
        public void CanConstructTab_TargetStringAndWordBankIsEmptyTest()
        {
            var result = Construct_Tabulation.CanConstructTab("", Array.Empty<string>());
            Assert.True(result);
        }

        [Theory]
        [InlineData("abcdef", new string[] { "ab", "abc", "cd", "def", "abcd" })]
        [InlineData("enterapotentpot", new string[] { "a", "p", "ent", "enter", "ot", "o", "t" })]
        [InlineData("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee",
            new string[] { "e", "ee", "eee", "eeee", "eeeee", "eeeeee" })]
        public void CanConstructTab_AssertMultipleTrueTest(string target, string[] wordBank)
        {
            var result = Construct_Tabulation.CanConstructTab(target, wordBank);
            Assert.True(result);
        }

        [Theory]
        [InlineData("skateboard", new string[] { "bo", "rd", "ate", "t", "ska", "sk", "boar" })]
        [InlineData("enterapotentpot", new string[] { "e", "p", "ent", "enter", "ot", "o", "t" })]
        [InlineData("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef",
            new string[] { "e", "ee", "eee", "eeee", "eeeee", "eeeeee" })]
        public void CanConstructTab_AssertMultipleFalseTest(string target, string[] wordBank)
        {
            var result = Construct_Tabulation.CanConstructTab(target, wordBank);
            Assert.False(result);
        }
    }
}
