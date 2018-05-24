namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        public int MajorityElement(int[] nums)
        {
            var majorNum = 0;
            var count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (count == 0)
                {
                    majorNum = nums[i];
                    count++;
                }
                else
                {
                    if (majorNum == nums[i])
                    {
                        count++;
                    }
                    else
                    {
                        count--;
                    }
                }
            }
            return majorNum;
        }
    }
}
