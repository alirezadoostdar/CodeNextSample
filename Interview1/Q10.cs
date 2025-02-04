using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview1
{
	//Tonight's Code Challenge
	//Problem:
	//Write a method to return the most frequent character in a string. If there are multiple characters with the same highest frequency, return the one that appears first in the string.

	//Example:
	//Input: "character"
	//Output: 'c'
	//
	//Constraints:
	//Ignore spaces and handle both uppercase and lowercase characters as case-insensitive.
	//The string will always have at least one character.
	//Let me know if you need clarification or hints! 
	public class Q10
	{
		public char GetFrequentChar(string data)
		{
			Dictionary<char, int> frequency = new Dictionary<char, int>();
			char mostFrequent = '\0';
			int maxFrequency = 0;

			foreach (char c in data.ToLower())
			{
				if (!char.IsLetterOrDigit(c)) // Ignore non-alphanumeric characters
					continue;

				// Count frequency of each character
				if (frequency.ContainsKey(c))
					frequency[c]++;
				else
					frequency[c] = 1;

				// Update the most frequent character with tie-breaking by appearance
				if (frequency[c] > maxFrequency ||
					(frequency[c] == maxFrequency && mostFrequent == '\0'))
				{
					mostFrequent = c;
					maxFrequency = frequency[c];
				}
			}

			return mostFrequent;
		}
	}
}