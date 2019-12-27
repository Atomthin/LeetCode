using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        /// <summary>
        /// 递归加缓存实现，只用递归会超时
        /// 执行用时 : 48 ms, 在所有 csharp 提交中击败了64.10% 的用户
        /// 内存消耗 : 14 MB, 在所有 csharp 提交中击败了100.00% 的用户
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        Dictionary<int, int> tempCache = new Dictionary<int, int>();
        public int Tribonacci(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            if (n == 2)
                return 1;
            var x = n - 3;
            if (tempCache.ContainsKey(n))
            {
                return tempCache[n];
            }
            var result = Tribonacci(x) + Tribonacci(x + 1) + Tribonacci(x + 2);
            tempCache.Add(n, result);
            return result;
        }
    }
}
