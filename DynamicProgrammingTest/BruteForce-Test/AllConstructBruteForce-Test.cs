namespace DynamicProgramming.BruteForce_Test
{
    public class AllConstructBruteForce_Test
    {
        [Fact]
        public void AllConstruct_TargetStringIsEmptyTest()
        {
            var result = Construct.AllConstruct("", new string[] { "abc", "def" });
            List<List<string>> emptyList = new()
            {
                new List<string>()
            };
            Assert.Equal(emptyList, result);
        }

        [Fact]
        public void AllConstruct_WordBankIsEmptyTest()
        {
            var result = Construct.AllConstruct("abc", Array.Empty<string>());
            Assert.Equal(new List<List<string>>(), result);
        }

        [Fact]
        public void AllConstruct_TargetStringAndWordBankIsEmptyTest()
        {
            var result = Construct.AllConstruct("", Array.Empty<string>());
            List<List<string>> emptyList = new()
            {
                new List<string>()
            };
            Assert.Equal(emptyList, result);
        }

        [Fact]
        public void AllConstruct_AssertMultipleTest()
        {
            var result = Construct.AllConstruct("purple",
                new string[] { "purp", "p", "ur", "le", "purpl" });
            List<List<string>> expected1 = new()
            {
                new List<string> { "purp", "le" },
                new List<string> { "p","ur","p","le" },
            };
            Assert.Equal(expected1, result);

            result = Construct.AllConstruct("abcdef",
                new string[] { "ab", "abc", "cd", "def", "abcd", "ef", "c" });
            List<List<string>> expected2 = new()
            {
                new List<string> { "ab", "cd", "ef"},
                new List<string> { "ab","c","def" },
                new List<string> { "abc", "def" },
                new List<string> { "abcd", "ef" },
            };
            Assert.Equal(expected2, result);

            result = Construct.AllConstruct("skateboard",
                new string[] { "bo", "rd", "ate", "t", "ska", "sk", "boar" });
            Assert.Equal(new List<List<string>>(), result);
        }
    }
}
