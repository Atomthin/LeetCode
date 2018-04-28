namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        public int SingleNumber(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                nums[0] ^= nums[i];
            }
            return nums[0];
        }
    }
}
