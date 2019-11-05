using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        /// <summary>
        /// 最基础，两遍遍历
        /// 第一次遍历找到最大的数和索引
        /// 第二次遍历进行判断
        /// 时间复杂度0(N)，空间复杂度O(1),因为只用了常数变量
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int DominantIndex(int[] nums)
        {
            var maxIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > nums[maxIndex])
                {
                    maxIndex = i;
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0 && i != maxIndex)
                {
                    if (nums[maxIndex] / nums[i] < 2)
                    {
                        return -1;
                    }
                }
            }
            return maxIndex;
        }
    }
}
