/**
The Hamming distance between two integers is the number of positions at which the corresponding bits are different.
Given two integers x and y, calculate the Hamming distance.
Note:
0 ≤ x, y < 231.
Example:
Input: x = 1, y = 4
Output: 2
Explanation:
1   (0 0 0 1)
4   (0 1 0 0)
       ↑   ↑
The above arrows point to positions where the corresponding bits are different.
*/




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HammingDistance
{
    class HammingDistance
    {
        public int HammingDistance_1(int x, int y)
        {
            int count = 0;
            for(int i=31; i>=0; i--)
            {
                if(((x>>i &1) ^ (y>>i &1)) == 1)//per bit compare
                {
                    count++;
                }
            }
            return count;
        }
    }
}
