using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview1
{
    public class Q4
    {
        public  int GetKMaxValue(int[] data, int k)
        {
            if (data == null || k <= 0 || k > data.Length)
                throw new ArgumentException("Invalid input: Ensure k is within the array bounds.");

            // Use a Min-Heap to store the top k elements
            PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();

            foreach (int num in data)
            {
                // Add the current number to the heap
                minHeap.Enqueue(num, num);

                // If the heap size exceeds k, remove the smallest element
                if (minHeap.Count > k)
                {
                    minHeap.Dequeue();
                }
            }

            // The root of the heap is the kth largest element
            return minHeap.Peek();
        }
    }
}
