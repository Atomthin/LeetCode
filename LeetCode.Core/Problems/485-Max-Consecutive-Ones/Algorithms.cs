namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            var count = 0;
            var startValue = nums[0];
            var temp = startValue == 1 ? 1 : 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (startValue == nums[i] && startValue == 1)
                {
                    temp++;
                }
                else
                {
                    if (temp > count)
                    {
                        count = temp;
                    }
                    startValue = nums[i];
                    temp = startValue == 1 ? 1 : 0;
                }
            }
            if (temp > count)
            {
                count = temp;
            }
            return count;
        }
    }
}
