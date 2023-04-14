namespace DynamicProgramming.Memoization_Test
{
    public class CountConstructMemo_Test
    {
        [Fact]
        public void CountConstructMemo_TargetStringIsEmptyTest()
        {
            var result = Construct_Memo.CountConstructMemo("", new string[] { "abc", "def" });
            Assert.Equal(1, result);
        }

        [Fact]
        public void CountConstructMemo_WordBankIsEmptyTest()
        {
            var result = Construct_Memo.CountConstructMemo("abc", Array.Empty<string>());
            Assert.Equal(0, result);
        }

        [Fact]
        public void CountConstructMemo_TargetStringAndWordBankIsEmptyTest()
        {
            var result = Construct_Memo.CountConstructMemo("", Array.Empty<string>());
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
        public void CountConstructMemo_AssertMultipleTest(string target, string[] wordBank, int expected)
        {
            var result = Construct_Memo.CountConstructMemo(target, wordBank);
            Assert.Equal(expected, result);
        }
    }
}