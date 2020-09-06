using System;
using System.Collections.Generic;

namespace Anagram
{
    public class AnagramSelector
    {
        public bool GivenStringPairThenCheckIsAnagram(string str1, string str2) {
            int noOfCharsInWord1 = str1.Length;
            int noOfCharsInWord2 = str2.Length;
            if (noOfCharsInWord1 != noOfCharsInWord2)
                return false;
            str1 = SortInputString(str1);
            str2 = SortInputString(str2);
            for (int index = 0; index < noOfCharsInWord1; index++)
                if (str1[index] != str2[index])return false;
            return true;
        }
        public static string SortInputString(string s){
            char[] charTypeArrayOfInputString = s.ToCharArray();
            Array.Sort(charTypeArrayOfInputString);
            return new string(charTypeArrayOfInputString);
        }
        public List<string> GivenListStringThenSelectAnagrams(string word, List<string> candidates) {
            List<string> listOfStringWhichAreAnagramWithGivenWord = new List<string>();
            for (int index = 0; index < candidates.Count; index++) {
                if (GivenStringPairThenCheckIsAnagram(word, candidates[index])) {
                    listOfStringWhichAreAnagramWithGivenWord.Add(candidates[index]);
                }
            }
            return listOfStringWhichAreAnagramWithGivenWord;
        }
    }
}
