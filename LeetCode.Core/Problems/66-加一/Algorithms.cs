using System;
using LeetCode.Core.Common;

namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        /// <summary>
        /// 比较傻的方法，就是数学运算，期待以后的改进
        /// </summary>
        /// <param name="digits"></param>
        /// <returns></returns>
        public int[] PlusOne(int[] digits)
        {
            var carry = 0;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (carry == 1)
                {
                    if (digits[i] + carry == 10)
                    {
                        digits[i] = 0;
                    }
                    else
                    {
                        digits[i] = digits[i] + carry;
                        return digits;
                    }
                }
                else
                {
                    if (digits[i] + 1 == 10)
                    {
                        carry = 1;
                        digits[i] = 0;
                    }
                    else
                    {
                        digits[i] = digits[i] + 1;
                        return digits;
                    }
                }
            }
            if (carry == 1)
            {
                var newArr = new int[digits.Length + 1];
                newArr[0] = 1;
                for (int i = 1; i < newArr.Length; i++)
                {
                    newArr[i] = 0;
                }
                return newArr;
            }
            return digits;
        }
    }
}
