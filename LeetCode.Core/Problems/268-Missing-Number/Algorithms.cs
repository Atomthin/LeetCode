using System;

namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        public int MissingNumber(int[] nums)
        {
            long sumIndex = nums.Length;
            long sumItem = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sumIndex += i;
                sumItem += nums[i];
            }
            return (int)(sumIndex - sumItem);
        }
    }
}
