using System.Collections.Generic;

namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        public int[] NextGreaterElement(int[] findNums, int[] nums)
        {
            var list = new List<int>();
            for (int i = 0; i < findNums.Length; i++)
            {
                var temp = false;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] == findNums[i])
                    {
                        for (int k = j; k < nums.Length; k++)
                        {
                            if (nums[k] > findNums[i])
                            {
                                list.Add(nums[k]);
                                temp = true;
                                break;
                            }
                        }
                    }
                }
                if (!temp)
                {
                    list.Add(-1);
                }
            }
            return list.ToArray();
        }
    }
}
