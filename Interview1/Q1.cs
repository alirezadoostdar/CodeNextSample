using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Interview1
{
    //Write a method in C# to find the first non-repeating character in a string.
    public static class Find
    {
        public static char FindFirstNonRepeatingChar(string str)
        {
            if (string.IsNullOrEmpty(str)) 
                return '\0';
            Dictionary<char,int> charList =new Dictionary<char, int>();
            foreach (char c in str)
            {
                if (charList.ContainsKey(c))
                {
                    charList[c]++;
                }
                else
                {
                    charList[c] = 1;
                }
            }

            foreach (char c in str)
            {
                if (charList[c]==1) 
                    return c;
            }
            return '\0';
        }
    }
}
