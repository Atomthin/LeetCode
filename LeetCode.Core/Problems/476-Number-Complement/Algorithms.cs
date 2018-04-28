using System;

namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        public int FindComplement(int num)
        {
            var binaryStr = Convert.ToString(num, 2);
            var newBinartStr = binaryStr.Replace('0', '1');
            return Convert.ToInt32(newBinartStr, 2) - num;
        }
    }
}
