namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        public int[] NumberOfLines(int[] widths, string S)
        {
            int res = 1, cur = 0;
            foreach (var item in S)
            {
                int width = widths[item - 'a'];
                res = cur + width > 100 ? res + 1 : res;
                cur = cur + width > 100 ? width : cur + width;
            }
            return new int[] { res, cur };
        }
    }
}
