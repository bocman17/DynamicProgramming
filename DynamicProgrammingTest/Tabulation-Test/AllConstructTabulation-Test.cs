using DynamicProgramming.Tabulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgrammingTest.Tabulation_Test
{
    public class AllConstructTabulation_Test
    {
        [Fact]
        public void AllConstructTabulation_TargetStringIsEmptyTest()
        {
            var result = Construct_Tabulation.AllConstructTab("", new string[] { "abc", "def" });
            List<List<string>> emptyList = new()
            {
                new List<string>()
            };
            Assert.Equal(emptyList, result);
        }

        [Fact]
        public void AllConstructTabulation_WordBankIsEmptyTest()
        {
            var result = Construct_Tabulation.AllConstructTab("abc", Array.Empty<string>());
            Assert.Equal(new List<List<string>>(){ }, result);
        }

        [Fact]
        public void AllConstructTabulation_TargetStringAndWordBankIsEmptyTest()
        {
            var result = Construct_Tabulation.AllConstructTab("", Array.Empty<string>());
            List<List<string>> emptyList = new()
            {
                new List<string>()
            };
            Assert.Equal(emptyList, result);
        }

        [Fact]
        public void AllConstructTabulation_AssertMultipleTest()
        {
            var result = Construct_Tabulation.AllConstructTab("purple",
                new string[] { "purp", "p", "ur", "le", "purpl" });
            List<List<string>> expected1 = new()
            {
                new List<string>() { "purp", "le" },
                new List<string>() { "p","ur","p","le" }
            };
            Assert.Equal(expected1, result);

            result = Construct_Tabulation.AllConstructTab("abcdef",
                new string[] { "ab", "abc", "cd", "def", "abcd", "ef", "c" });
            List<List<string>> expected2 = new()
            {
                new List<string>() { "abc", "def" },
                new List<string>() { "ab","c","def"  },
                new List<string>() { "abcd", "ef" },
                new List<string>() { "ab", "cd", "ef" },

            };   
            
            Assert.Equal(expected2, result);

            result = Construct_Tabulation.AllConstructTab("skateboard",
                new string[] { "bo", "rd", "ate", "t", "ska", "sk", "boar" });
            List<List<string>> expected3 = new() { };
            Assert.Equal(expected3, result);

            result = Construct_Tabulation.AllConstructTab("aaaaaaaaaz",
                new string[] { "a", "aa", "aaa", "aaaa", "aaaaa" });
            List<List<string>> expected4 = new() { };
            Assert.Equal(expected4, result);
        }
    }
}
