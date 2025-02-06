using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview1
{
	public class Q11
	{
		//Problem:
		//Write a method to rotate an array to the right by k positions.The rotation should be circular, meaning that the elements that go beyond the end of the array wrap around to the beginning.

		//Example:
		//Input:
		//array = [1, 2, 3, 4, 5], k = 2
		//Output:
		//[4, 5, 1, 2, 3]

		//		Constraints:
		//k will always be a non-negative integer.
		//Handle cases where k is larger than the length of the array (e.g., k = 7 when the array length is 5).
		//Do not use extra arrays if possible(in-place solution preferred).
		public int[] Rotate(int[] data, int index)
		{
			if (index < 0 && index >= data.Length)
				throw new ArgumentOutOfRangeException("index");
			int a = 0;
			int b = 0;
			int indexValue = data[index];
			for (int i = 0; i < data.Length; i++)
			{
				if( index+1<data.Length )
				{
					a = data[i]; //1
					data[index] = a;

					b = data[index+1];
					data[i] = b;
				
				}
				else if(index+1 == data.Length)
				{
					data[index] = indexValue;
				}
				index++;
			}
			return data;
		}
	}
}
