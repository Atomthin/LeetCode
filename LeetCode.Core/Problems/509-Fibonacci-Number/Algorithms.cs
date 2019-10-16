namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        public int Fib(int N)
        {
            if (N == 0)
                return 0;
            if (N == 1)
                return 1;
            return Fib(N - 1) + Fib(N - 2);
        }
    }
}
