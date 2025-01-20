using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Interview1
{
    //Problem: Write a C# function to check if a given string is a palindrome. A palindrome is a word,
    //phrase, or sequence that reads the same backward as forward (ignoring spaces, punctuation, and capitalization).
    //Example:
    //Input: "A man, a plan, a canal, Panama"
    //Output: True
    public class Q2
    {
        public bool IsPalindrome(string str)
        {
            str = RemoveNonAlphanumeric(str).ToLower();
            string revers =ArrayToString(str.Reverse().ToArray());
            return (str == revers);
        }

        public string RemoveNonAlphanumeric(string str)
        {
            // Use Regex to replace non-alphanumeric characters with an empty string
            return Regex.Replace(str, "[^a-zA-Z0-9]", "");
        }

        public string ArrayToString(char[] chars)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in chars)
            {
                sb.Append(c);
            }
            return sb.ToString();
        }
    }
}
