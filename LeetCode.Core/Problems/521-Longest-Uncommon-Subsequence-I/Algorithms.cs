using System;

namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        public int FindLUSlength(string a, string b)
        {
            return a == b ? -1 : Math.Max(a.Length, b.Length);
        }
    }
}
