using System;
using System.Collections.Generic;

namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        public int[] FindDiagonalOrder(int[,] matrix)
        {
            if (matrix == null || matrix.Length == 0 || matrix.GetLength(0) == 0)
            {
                return new int[0];
            }
            var index = 0;
            var row = matrix.GetLength(0);
            var col = matrix.GetLength(1);
            var resultArr = new int[row * col];
            for (int i = 0; i < row + col - 1; i++)
            {
                //i为0或偶数时 沿对角线向上遍历 
                if (i == 0 || i % 2 == 0)
                {
                    //发现规律x+y = i 然后找边界（x坐标超过主对角线时的情况）
                    var x = i < row ? i : row - 1;
                    var y = i - x;
                    //开始遍历 x坐标不断减 y坐标不断加 当x减到0 或者 y加到列n的值
                    while (x >= 0 && y < col)
                    {
                        resultArr[index] = matrix[x, y];
                        x--;
                        y++;
                        index++;
                    }
                }
                else
                {
                    //沿对角线向下遍历
                    var y = i < col ? i : col - 1;
                    var x = i - y;
                    //y坐标不断减 x坐标不断加 当y减到0 或者 x加到行m的值
                    while (y >= 0 && x < row)
                    {
                        resultArr[index] = matrix[x, y];
                        y--;
                        x++;
                        index++;
                    }
                }
            }
            return resultArr;
        }
    }
}
