using System;
using System.Collections.Generic;
using System.Text;

namespace Anagram
{
    public class AnagramPairChecker
    {
        public bool WordPairIsAnagram(string str1, string str2)
        {
            int noOfCharsInWord1 = str1.Length;
            int noOfCharsInWord2 = str2.Length;
            if (noOfCharsInWord1 != noOfCharsInWord2)
            {
                return false;
            }

            str1 = SortString.SortInputString(str1);
            str2 = SortString.SortInputString(str2);
            
            return StringEqual.CheckLetterByLetter(str1, str2, noOfCharsInWord1);
        }
        
    }
}
