using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Interview1
{
	//Problem:
	//Write a C# method to find the first missing positive integer in an unsorted array.

	//Example:
	//Input: [3, 4, -1, 1]
	//	Output: 2

	//Input: [1, 2, 0]
	//	Output: 3

	//Constraints:
	//The missing number must be positive.
	//Your solution should run in O(n) time and use constant space O(1) (no extra arrays).
	//You cannot modify the input array.
	public class Q8
	{
		//public int GetMissingPositiveNumber(int[] data)
		//{
		//	int sumPlus = 0;
		//	int sumExpect = 0;
		//	int min = 0;
		//	int max = 0;
		//	foreach (int i in data)
		//	{
		//		if (i> 0 && (i < min || min == 0))
		//			min = i;
		//		if (i > 0 && i > max)
		//			max = i;
		//		if (i > 0)
		//			sumPlus += i;
		//	}
		//	for (int i = min; i< min+data.Length;i++)
		//		sumExpect += i;
		//	return sumExpect - sumPlus;
		//}

		public int GetMissingPositiveNumber(int[] data)
		{
			int n = data.Length;

			// Step 1: Place each number in its correct index
			for (int i = 0; i < n; i++)
			{
				while (data[i] > 0 && data[i] <= n && data[i] != data[data[i] - 1])
				{
					// Swap data[i] with data[data[i] - 1]
					int temp = data[data[i] - 1];
					data[data[i] - 1] = data[i];
					data[i] = temp;
				}
			}

			// Step 2: Find the first missing positive number
			for (int i = 0; i < n; i++)
			{
				if (data[i] != i + 1)
					return i + 1;
			}

			// If all numbers are in place, return next positive integer
			return n + 1;
		}
	}
}
