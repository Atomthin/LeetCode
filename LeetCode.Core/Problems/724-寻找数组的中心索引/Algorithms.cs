using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        /// <summary>
        /// L + R + nums[x] = T
        /// L = R
        /// nums[x] = T - 2 * L
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int PivotIndex(int[] nums)
        {
            var sumTotal = 0;
            var sumLeft = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                sumTotal += nums[i];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == sumTotal - 2 * sumLeft)
                {
                    return i;
                }
                sumLeft += nums[i];
            }
            return -1;
        }
    }
}
