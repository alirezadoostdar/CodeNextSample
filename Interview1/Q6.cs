using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview1
{
    public class Q6
    {
        public int GetMissingNumber(int[] data)
        {
            int sumArray = 0;
            int MainSum = 0;
            for (int i = 0; i <= data.Length; i++)
            {
                if(i<data.Length)
                sumArray += data[i];
                MainSum += (i+1);
            }
            return MainSum - sumArray;
        }
    }
}
