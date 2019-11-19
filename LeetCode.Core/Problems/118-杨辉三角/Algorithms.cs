using System.Collections.Generic;

namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        /// <summary>
        /// 纯粹总结规律
        /// 执行用时 :244 ms, 在所有 csharp 提交中击败了 94.44% 的用户
        /// 内存消耗 :24.8 MB, 在所有 csharp 提交中击败了5.55%的用户
        /// </summary>
        /// <param name="numRows"></param>
        /// <returns></returns>
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (numRows == 0)
            {
                return result;
            }
            var prevList = new List<int> { 1 };
            result.Add(prevList);
            for (int i = 2; i < numRows + 1; i++)
            {
                var temp = new List<int>(i) { 1 };
                for (int j = 1; j < i - 1; j++)
                {
                    temp.Add(prevList[j-1] + prevList[j]);
                }
                temp.Add(1);
                prevList = temp;
                result.Add(prevList);
            }
            return result;
        }
    }
}
