using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview1
{
    public class Q3
    {
        public int GetSecondMaxValue(int[] data)
        {
            if (data.Length <= 2)
                throw new Exception("array lenght can not less than 2");
          
            var result = data.Distinct().OrderByDescending(x => x).ToList();
            return result[1];
        }
    }
}
