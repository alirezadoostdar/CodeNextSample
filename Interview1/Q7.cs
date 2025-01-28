using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview1
{
//	Problem:
//Write a C# method to find the longest palindrome substring in a given string.

//Example:
//Input: "babad"
//Output: "bab" (or "aba", either is acceptable)

//Input: "cbbd"
//Output: "bb"

//Constraints:
//The palindrome should be contiguous.

	public class Q7
	{
		public string LongestPalindrome(string s)
		{
			if (string.IsNullOrEmpty(s) || s.Length < 1)
				return "";

			int start = 0, end = 0;

			for (int i = 0; i < s.Length; i++)
			{
				// Expand for odd-length palindromes (e.g., "aba")
				int len1 = ExpandAroundCenter(s, i, i);

				// Expand for even-length palindromes (e.g., "abba")
				int len2 = ExpandAroundCenter(s, i, i + 1);

				// Get the maximum length from both cases
				int len = Math.Max(len1, len2);

				// Update the start and end indices of the longest palindrome
				if (len > end - start)
				{
					start = i - (len - 1) / 2;
					end = i + len / 2;
				}
			}

			// Extract the longest palindrome substring
			return s.Substring(start, end - start + 1);
		}

		// Helper method to expand around a center
		private int ExpandAroundCenter(string s, int left, int right)
		{
			while (left >= 0 && right < s.Length && s[left] == s[right])
			{
				left--;  // Expand to the left
				right++; // Expand to the right
			}

			// Return the length of the palindrome
			return right - left - 1;
		}
	}
}
