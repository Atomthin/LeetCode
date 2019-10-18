using System.Text;

namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        /// <summary>
        /// 动态规划: 基本思路：用两个变量，一个存储当前最大的收益，一个存储当前的最小值。用当前的卖出价值，减去前面的最小值，即为当前收益,随着遍历更新最大收益和最小值。空间复杂度比较好, O(l)，时间复杂度一般，应该是O(n)。
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public int MaxProfit(int[] prices)
        {
            if (prices.Length < 2) return 0;
            int maxProfit = 0;
            int min = prices[0];
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < min)
                {
                    min = prices[i];
                }
                maxProfit = maxProfit > (prices[i] - min) ? maxProfit : (prices[i] - min);
            }
            return maxProfit;
        }
    }
}
