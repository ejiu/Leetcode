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
            string xStr = Convert.ToString(x, 2);
            string yStr = Convert.ToString(y, 2);
            int max = xStr.Length > yStr.Length ? xStr.Length : yStr.Length;

            char[] xChars = new char[max];
            
            char[] yChars = new char[max];

            for(int i=0; i<max; i++)
            {
                //if('' == xChars[i])
                //{
                //    xChars[i] = '0';
                //}

                //if (null == yChars[i])
                //{
                //    yChars[i] = '0';
                //}

                if(xChars[i] == yChars[i])
                {

                }
            }





            Console.WriteLine(xStr +"\n" +yStr);

            return 0;
        }
    }
}
