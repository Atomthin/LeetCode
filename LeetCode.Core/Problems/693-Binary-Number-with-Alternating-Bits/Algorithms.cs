using System;

namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        public bool HasAlternatingBits(int n)
        {
            if (n == 1)
            {
                return true;
            }
            if (n == 2)
            {
                return true;
            }
            var binary = Convert.ToString(n, 2);
            for (int i = 0; i < binary.Length; i++)
            {
                if (i == binary.Length - 1)
                {
                    if (binary[i] == binary[i - 1])
                    {
                        return false;
                    }
                }
                else
                {
                    if (!(binary[i] == '1' && binary[i + 1] == '0' || binary[i] == '0' && binary[i + 1] == '1'))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
