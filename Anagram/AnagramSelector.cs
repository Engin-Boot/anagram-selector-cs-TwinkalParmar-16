using System;
using System.Collections.Generic;
using System.Text;

namespace Anagram
{
    public class AnagramSelector
    {
        public List<string> SelectAnagrams(string word, List<string> candidates)
        {
            List<string> listOfStringWhichAreAnagramWithGivenWord = new List<string>();
            for (int index = 0; index < candidates.Count; index++)
            {
                AnagramPairChecker checkPairIsAnagram = new AnagramPairChecker();
                if (checkPairIsAnagram.WordPairIsAnagram(word, candidates[index]))
                {
                    listOfStringWhichAreAnagramWithGivenWord.Add(candidates[index]);
                }
            }
            return listOfStringWhichAreAnagramWithGivenWord;
        }
    }
}
