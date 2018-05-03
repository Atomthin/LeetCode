namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        public int CountPrimeSetBits(int L, int R)
        {
            int count = 0;
            for (int i = L; i <= R; i++)
            {
                int bitsCount = GetBitsCount(i);
                if (IsPrime(bitsCount)) count++;
            }

            return count;
        }

        private int GetBitsCount(int a)
        {
            int count = 0;
            while (a > 0)
            {
                count += a % 2;
                a /= 2;
            }
            return count;
        }

        private bool IsPrime(int num)
        {
            if (num <= 1) return false;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
    }
}
