namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        public int HammingDistance(int x, int y)
        {
            var num = x ^ y;
            var count = 0;
            while (num > 0)
            {
                ++count;
                num = (num - 1) & num;
            }
            return count;
        }
    }
}
