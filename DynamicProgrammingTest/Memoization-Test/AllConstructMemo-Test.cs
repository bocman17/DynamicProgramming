using DynamicProgramming;
using DynamicProgramming.Memoization;
using Xunit;

namespace DynamicProgrammingTest
{
    public class AllConstructMemo_Test
    {
        [Fact]
        public void AllConstructMemo_TargetStringIsEmptyTest()
        {
            var result = Construct_Memo.AllConstructMemo("", new string[] { "abc", "def" });
            List<List<string>> emptyList = new()
            {
                new List<string>()
            };
            Assert.Equal(emptyList, result);
        }

        [Fact]
        public void AllConstructMemo_WordBankIsEmptyTest()
        {
            var result = Construct_Memo.AllConstructMemo("abc", Array.Empty<string>());
            Assert.Equal(new List<List<string>>(), result);
        }

        [Fact]
        public void AllConstructMemo_TargetStringAndWordBankIsEmptyTest()
        {
            var result = Construct_Memo.AllConstructMemo("", Array.Empty<string>());
            List<List<string>> emptyList = new()
            {
                new List<string>()
            };
            Assert.Equal(emptyList, result);
        }

        [Fact]
        public void AllConstructMemo_AssertMultipleTest()
        {
            var result = Construct_Memo.AllConstructMemo("purple",
                new string[] { "purp", "p", "ur", "le", "purpl" });
            List<List<string>> expected1 = new()
            {
                new List<string> { "purp", "le" },
                new List<string> { "p","ur","p","le" },
            };
            Assert.Equal(expected1, result);

            result = Construct_Memo.AllConstructMemo("abcdef",
                new string[] { "ab", "abc", "cd", "def", "abcd", "ef", "c" });
            List<List<string>> expected2 = new()
            {
                new List<string> { "ab", "cd", "ef"},
                new List<string> { "ab","c","def" },
                new List<string> { "abc", "def" },
                new List<string> { "abcd", "ef" },
            };
            Assert.Equal(expected2, result);

            result = Construct_Memo.AllConstructMemo("skateboard",
                new string[] { "bo", "rd", "ate", "t", "ska", "sk", "boar" });
            Assert.Equal(new List<List<string>>(), result);

            result = Construct_Memo.AllConstructMemo("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaz",
                new string[] { "a", "aa", "aaa", "aaaa", "aaaaa" });
            Assert.Equal(new List<List<string>>(), result);
        }
    }
}