using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToeplitzMatrix
{
    public class Solution
    {
        public bool IsToeplitzMatrix(int[,] matrix)
        {
            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                for (int j = matrix.GetLength(1) - 1; j > 0; j--)
                {
                    if (matrix[i - 1, j - 1] != matrix[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
