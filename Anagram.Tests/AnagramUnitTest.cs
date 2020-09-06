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
            AnagramSelector selector = new AnagramSelector();
            Assert.True(selector.GivenStringPairThenCheckIsAnagram("restful", "fluster"));
            Assert.True(selector.GivenStringPairThenCheckIsAnagram("forty five", "over fifty"));
            Assert.True(selector.GivenStringPairThenCheckIsAnagram("",""));
        }
        [Fact]
        public void ReturnFalseForGivenAnag()
        {
            AnagramSelector selector = new AnagramSelector();
            Assert.False(selector.GivenStringPairThenCheckIsAnagram("something", "else"));
            Assert.False(selector.GivenStringPairThenCheckIsAnagram("","iAmNotEmpty"));
        }
        [Fact]
        public void TestForSelectsAnagramsOfAWordIsCorrectOrNot()
        {
            AnagramSelector selector = new AnagramSelector();
            var selection = selector.GivenListStringThenSelectAnagrams("master",new List<string>{"stream", "something", "maters"});
            Assert.True(selection.SequenceEqual(new List<string>{"stream", "maters"}));
        }
    }
}
