using DynamicProgramming;
using DynamicProgramming.Memoization;
using Xunit;

namespace DynamicProgrammingTest
{
    public class CanConstructMemo_Test
    {
        [Fact]
        public void CanConstructMemo_TargetStringIsEmptyTest()
        {
            var result = Construct_Memo.CanConstructMemo("", new string[] { "abc", "def" });
            Assert.True(result);
        }

        [Fact]
        public void CanConstructMemo_WordBankIsEmptyTest()
        {
            var result = Construct_Memo.CanConstructMemo("abc", Array.Empty<string>());
            Assert.False(result);
        }

        [Fact]
        public void CanConstructMemo_TargetStringAndWordBankIsEmptyTest()
        {
            var result = Construct_Memo.CanConstructMemo("", Array.Empty<string>());
            Assert.True(result);
        }

        [Theory]
        [InlineData("abcdef", new string[] { "ab", "abc", "cd", "def", "abcd" })]
        [InlineData("enterapotentpot", new string[] { "a", "p", "ent", "enter", "ot", "o", "t" })]
        [InlineData("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee", 
            new string[] { "e", "ee", "eee", "eeee", "eeeee", "eeeeee" })]
        public void CanConstructMemo_AssertMultipleTrueTest(string target, string[] wordBank)
        {
            var result = Construct_Memo.CanConstructMemo(target, wordBank);
            Assert.True(result);
        }

        [Theory]
        [InlineData("skateboard", new string[] { "bo", "rd", "ate", "t", "ska", "sk", "boar" })]
        [InlineData("enterapotentpot", new string[] { "e", "p", "ent", "enter", "ot", "o", "t" })]
        [InlineData("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef",
            new string[] { "e", "ee", "eee", "eeee", "eeeee", "eeeeee" })]
        public void CanConstructMemo_AssertMultipleFalseTest(string target, string[] wordBank)
        {
            var result = Construct_Memo.CanConstructMemo(target, wordBank);
            Assert.False(result);
        }

    }
}