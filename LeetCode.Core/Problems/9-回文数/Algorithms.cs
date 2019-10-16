using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        public bool IsPalindrome(int x)
        {
            var str = x.ToString();
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
