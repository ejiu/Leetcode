/*Initially, there is a Robot at position(0, 0). Given a sequence of its moves, judge if this robot makes a circle, which means it moves back to the original place.
The move sequence is represented by a string. And each move is represent by a character. The valid robot moves are R (Right), L (Left), U (Up) and D (down).
The output should be true or false representing whether the robot makes a circle.
Example 1:
Input: "UD"
Output: true
Example 2:
Input: "LL"
Output: false
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JudgeRouteCircle
{
    public class Solution
    {
        public bool JudgeRouteCircle(string moves)
        {
            if(moves.Length%2 != 0)
            {
                return false;
            }
            int countUD = 0;
            int countLR = 0;
            char[] sequence = moves.ToCharArray();
            for(int i=0; i<sequence.Length; i++)
            {
                switch (sequence[i])
                {
                    case 'U':
                        countUD++;
                        break;
                    case 'D':
                        countUD--;
                        break;
                    case 'L':
                        countLR++;
                        break;
                    case 'R':
                        countLR--;
                        break;
                    default:
                        break;
                }
            }
            if(0==countLR && 0==countUD)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
