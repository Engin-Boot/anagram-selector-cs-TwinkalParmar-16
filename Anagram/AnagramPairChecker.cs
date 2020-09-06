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
                return false;
            str1 = SortInputString(str1);
            str2 = SortInputString(str2);
            for (int index = 0; index < noOfCharsInWord1; index++)
                if (str1[index] != str2[index]) return false;
            return true;
        }
        public static string SortInputString(string s)
        {
            char[] charTypeArrayOfInputString = s.ToCharArray();
            Array.Sort(charTypeArrayOfInputString);
            return new string(charTypeArrayOfInputString);
        }
    }
}
