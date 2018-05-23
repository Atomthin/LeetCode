using System;
using System.Collections.Generic;

namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            var list = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int index = Math.Abs(nums[i]) - 1;
                if (nums[index] > 0) nums[index] = -nums[index];
            }
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] > 0) list.Add(j + 1);
            }
            return list;
        }
    }
}
