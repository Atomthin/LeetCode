using System.Collections.Generic;
using System.Text;

namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        /// <summary>
        /// 又是一道递归题，
        /// 执行用时 : 44 ms, 在所有 csharp 提交中击败了 84.84% 的用户
        /// 内存消耗 : 14 MB, 在所有 csharp 提交中击败了 5.98% 的用户
        /// </summary>
        Dictionary<int, int> tempCacheClimbStairs = new Dictionary<int, int>();
        public int ClimbStairs(int n)
        {
            if (n == 1)
                return 1;
            if (n == 2)
                return 2;
            if (tempCacheClimbStairs.ContainsKey(n))
            {
                return tempCacheClimbStairs[n];
            }
            var result = ClimbStairs(n - 1) + ClimbStairs(n - 2);
            tempCacheClimbStairs.Add(n, result);
            return result;
        }
    }
}
