namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        public void MoveZeroes(int[] nums)
        {
            for (int i = 0, j = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    if (i != j)
                    {
                        nums[j] = nums[i];
                        nums[i] = 0;
                    }
                    j++;
                }
            }
        }
    }
}
