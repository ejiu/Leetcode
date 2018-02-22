/*
A self-dividing number is a number that is divisible by every digit it contains.
For example, 128 is a self-dividing number because 128 % 1 == 0, 128 % 2 == 0, and 128 % 8 == 0.
Also, a self-dividing number is not allowed to contain the digit zero.
Given a lower and upper number bound, output a list of every possible self dividing number, including the bounds if possible.
Example 1:
Input: 
left = 1, right = 22
Output: [1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 15, 22]
Note:
The boundaries of each input argument are 1 <= left <= right <= 10000.
 */

using System.Collections.Generic;


namespace SelfDividingNumbers
{
    public class Solution
    {
        public IList<int> SelfDividingNumbers(int left, int right)
        {
            int temp;
            bool trueNum = true;
            IList<int> list = new List<int>();
            for (int i=left; i<= right; i++)
            {
                temp = i;
                do
                {
                    if ((temp%10) == 0 || (i%(temp%10) != 0))
                    {
                        trueNum = false;
                        break;
                    }
                    temp = temp / 10;
                } while (temp != 0);

                if(trueNum)
                {
                    list.Add(i);
                }
                trueNum = true;
            }
            return list;
        }
    }
}
