using System;
using System.Collections.Generic;

namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        /// <summary>
        /// 和原题不一样，原题输入的是一个交错数组，其实应该是一个二维数组
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public IList<int> SpiralOrder(int[,] matrix)
        {
            var result = new List<int>();
            int row = matrix.GetLength(0);
            int column = matrix.GetLength(1);

            if (row == 1 || column == 1)
            {
                foreach (var item in matrix)
                {
                    result.Add(item);
                }
                return result;
            }

            int maxDepth = Math.Min(row, column) - 1;
            int currentDepth = 0;
            //position has: 0:right, 1:down, 2:left, 3:up
            int currentPosition = 0;

            int top = 0;
            int right = column - 1;
            int bottom = row - 1;
            int left = 0;

            while (currentDepth < maxDepth)
            {
                for (int j = left; j <= right; j++)
                    result.Add(matrix[top, j]);

                top++;

                if (top > bottom)
                    break;

                for (int i = top; i <= bottom; i++)
                {
                    result.Add(matrix[i, right]);
                }

                right--;

                if (left > right)
                    break;

                for (int j = right; j >= left; j--)
                {
                    result.Add(matrix[bottom, j]);
                }
                bottom--;

                if (top > bottom)
                    break;

                for (int i = bottom; i >= top; i--)
                {
                    result.Add(matrix[i, left]);
                }
                left++;

                if (left > right)
                    break;

            }
            return result;
        }
    }
}
