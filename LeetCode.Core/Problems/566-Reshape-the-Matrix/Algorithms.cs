using System.Collections.Generic;

namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        public int[,] MatrixReshape(int[,] nums, int r, int c)
        {
            if (nums.Length < r * c)
            {
                return nums;
            }
            var arr = new int[r, c];
            var list = new List<int>();
            foreach (var item in nums)
            {
                list.Add(item); ;
            }
            var count = 0;
            for (int j = 0; j < r; j++)
            {
                for (int k = 0; k < c; k++)
                {
                    arr[j, k] = list[count];
                    count++;
                }
            }
            return arr;
        }
    }
}
