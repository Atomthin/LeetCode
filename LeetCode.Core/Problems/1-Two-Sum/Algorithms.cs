using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int i = 0, j = nums.Count() - 1;
            int[] ret = new int[2];
            Dictionary<int, int> indices = new Dictionary<int, int>();
            for (int k = 0; k < nums.Count(); k++)
            {
                if (!indices.ContainsKey(nums[k]))
                {
                    indices.Add(nums[k], k + 1);
                }
                else if (nums[k] * 2 == target)
                {
                    ret[0] = indices[nums[k]] - 1;
                    ret[1] = k;
                    return ret;
                }
            }
            Array.Sort(nums);
            while (i < j)
            {
                if (nums[i] + nums[j] > target)
                {
                    j--;
                }
                else if (nums[i] + nums[j] < target)
                {
                    i++;
                }
                else
                {
                    ret[0] = (Math.Min(indices[nums[i]], indices[nums[j]])) - 1;
                    ret[1] = (Math.Max(indices[nums[i]], indices[nums[j]])) - 1;
                    break;
                }
            }
            return ret;
        }
    }
}
