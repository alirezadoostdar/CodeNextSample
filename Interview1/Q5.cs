using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview1
{
    public class Q5
    {
        public bool IsAnagrams(string a, string b)
        {
            if (a.Length != b.Length)
                return false;

            // Create frequency dictionaries for both strings
            Dictionary<char, int> charCountA = new Dictionary<char, int>();
            Dictionary<char, int> charCountB = new Dictionary<char, int>();

            // Count characters in string `a`
            foreach (char c in a.ToLower())
            {
                if (charCountA.ContainsKey(c))
                    charCountA[c]++;
                else
                    charCountA[c] = 1;
            }

            // Count characters in string `b`
            foreach (char c in b.ToLower())
            {
                if (charCountB.ContainsKey(c))
                    charCountB[c]++;
                else
                    charCountB[c] = 1;
            }

            // Compare both dictionaries
            foreach (var pair in charCountA)
            {
                if (!charCountB.ContainsKey(pair.Key) || charCountB[pair.Key] != pair.Value)
                    return false;
            }

            return true;

            //int sumA=0, sumB=0
            //    ;
            //foreach (byte c in Encoding.ASCII.GetBytes(a.ToLower()))
            //    sumA += c;

            //foreach (byte c in Encoding.ASCII.GetBytes(b.ToLower()))
            //    sumB += c;

            //return (sumA == sumB);
        }
    }
}
