using System;
using System.Collections.Generic;
using System.Text;

namespace Anagram
{
    public class StringEqual
    {
        public static bool CheckLetterByLetter(string str1, string str2, int lengthOfString) {

            for (int index = 0; index < lengthOfString; index++)
            {
                if (str1[index] != str2[index]) 
                    return false;
            }
            
            return true;

        }
    }
}
