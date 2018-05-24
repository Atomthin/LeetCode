using System;

namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        public int RotatedDigits(int N)
        {
            int count = 0;
            for (int i = 1; i <= N; i++)
            {
                if (IsValid(i))
                    count++;
            }
            return count;
        }

        public bool IsValid(int i)
        {
            var valid = false;
            while (i > 0)
            {
                if (i % 10 == 2 || i % 10 == 5 || i % 10 == 6 || i % 10 == 9)
                    valid = true;
                if (i % 10 == 3 || i % 10 == 4 || i % 10 == 7)
                    return false;
                i = i / 10;
            }
            return valid;
        }
    }
}
