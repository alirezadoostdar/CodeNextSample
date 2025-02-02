using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview1
{
	//Problem:
	//Write a C# method to find all pairs in an array that sum up to a given target value.

	//Example:
	//Input: nums = [2, 7, 4, -1, 5, 3, 1], target = 6
	//Output: [(2, 4), (7, -1), (5, 1)]

	//Constraints:
	//Return unique pairs(e.g., [2, 4] and[4, 2] should be treated as the same pair).
	//The solution should run in O(n) time.
	//Use O(n) extra space or less.
	public class Q9
	{
		public List<Tuple<int, int>> GetPairSumTarget(int[] data, int target)
		{
			HashSet<int> seen = new HashSet<int>();
			List<Tuple<int, int>> result = new List<Tuple<int,int>>();
			foreach (int item in data) 
			{
				int complement = target - item;
				if (seen.Contains(complement))
				{
					result.Add(Tuple.Create(complement, item));
				}

				seen.Add(item);
			}

			return result;
		}
	}
}
