using System;
using System.Linq;

namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        public int ArrayPairSum(int[] nums)
        {
            Array.Sort(nums);
            var sum = 0;
            for (var i = 0; i < nums.Count(); i++)
            {
                if ((i & 1) == 0)
                {
                    sum += nums[i];
                }
            }
            return sum;
        }
    }
}
