using System;
using Xunit;
using Anagram;
using System.Collections.Generic;
using System.Linq;

namespace Anagram.Tests
{
    public class AnagramUnitTest
    {
        [Fact]
        public void ReturnTrueForGivenAnagramPair()
        {
            AnagramPairChecker selector = new AnagramPairChecker();
            Assert.True(selector.WordPairIsAnagram("restful", "fluster"));
            Assert.True(selector.WordPairIsAnagram("forty five", "over fifty"));
            Assert.True(selector.WordPairIsAnagram("",""));
        }
        [Fact]
        public void ReturnFalseForGivenAnag()
        {
            AnagramPairChecker selector = new AnagramPairChecker();
            Assert.False(selector.WordPairIsAnagram("something", "else"));
            Assert.False(selector.WordPairIsAnagram("","iAmNotEmpty"));
        }
        [Fact]
        public void TestForSelectsAnagramsOfAWordIsCorrectOrNot()
        {
            AnagramSelector selector = new AnagramSelector();
            var selection = selector.SelectAnagrams("master",new List<string>{"stream", "something", "maters"});
            Assert.True(selection.SequenceEqual(new List<string>{"stream", "maters"}));
        }
    }
}
