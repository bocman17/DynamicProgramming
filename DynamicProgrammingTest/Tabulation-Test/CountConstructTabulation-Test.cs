namespace DynamicProgrammingTest.Tabulation_Test
{
    public class CountConstructTabulation_Test
    {
        [Fact]
        public void CountConstructTab_TargetStringIsEmptyTest()
        {
            var result = Construct_Tabulation.CountConstructTab("", new string[] { "abc", "def" });
            Assert.Equal(1, result);
        }

        [Fact]
        public void CountConstructTab_WordBankIsEmptyTest()
        {
            var result = Construct_Tabulation.CountConstructTab("abc", Array.Empty<string>());
            Assert.Equal(0, result);
        }

        [Fact]
        public void CountConstructTab_TargetStringAndWordBankIsEmptyTest()
        {
            var result = Construct_Tabulation.CountConstructTab("", Array.Empty<string>());
            Assert.Equal(1, result);
        }

        [Theory]
        [InlineData("purple", new string[] { "purp", "p", "ur", "le", "purpl" }, 2)]
        [InlineData("abcdef", new string[] { "ab", "abc", "cd", "def", "abcd" }, 1)]
        [InlineData("skateboard",
            new string[] { "bo", "rd", "ate", "t", "ska", "sk", "boar" }, 0)]
        [InlineData("enterapotentpot",
            new string[] { "a", "p", "ent", "enter", "ot", "o", "t" }, 4)]
        [InlineData("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef",
            new string[] { "e", "ee", "eee", "eeee", "eeeee", "eeeeee" }, 0)]
        public void CountConstructTab_AssertMultipleTest(string target, string[] wordBank, int expected)
        {
            var result = Construct_Tabulation.CountConstructTab(target, wordBank);
            Assert.Equal(expected, result);
        }
    }
}
