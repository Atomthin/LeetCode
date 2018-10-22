namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        public int PeakIndexInMountainArray(int[] A)
        {
            var index = -1;
            for (var i = 0; i < A.Length; i++)
            {
                if (i == 0 || i + 1 == A.Length || A[i] < A[i - 1] || A[i] < A[i + 1])
                    continue;
                index = i;
            }
            return index;
        }
    }
}
