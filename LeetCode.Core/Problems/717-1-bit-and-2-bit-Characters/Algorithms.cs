namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        public bool IsOneBitCharacter(int[] bits)
        {
            if (bits.Length >= 2 && bits[bits.Length - 2] == 0)
            {
                return true;
            }
            var result = false;
            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i] == 1)
                {
                    i++;
                    result = false;
                    continue;
                }
                else
                {
                    result = true;
                }
            }
            return result;
        }
    }
}
