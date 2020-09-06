using System;
using System.Collections.Generic;
using System.Text;

namespace Anagram
{
    public class SortString
    {
        public static string SortInputString(string s)
        {
            char[] charTypeArrayOfInputString = s.ToCharArray();
            Array.Sort(charTypeArrayOfInputString);
            return new string(charTypeArrayOfInputString);
        }
    }
}
