using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberComplement
{
    public class Solution
    {
        public int FindComplement(int num)
        {
            int  mask = ~0;
            while ((num & mask) != 0)
            {
                mask <<= 1;
            }
            return ~mask & ~num;
        }
    }
}
