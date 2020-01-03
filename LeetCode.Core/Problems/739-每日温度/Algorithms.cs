using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        /// <summary>
        /// 注释中的是暴力解法，可以解出来，但是会非常耗时
        /// 运用栈解决问题，通过当前温度和栈顶索引所代表的温度比较来找到温度升高的位置
        /// </summary>
        /// <param name="T"></param>
        /// <returns></returns>
        public int[] DailyTemperatures(int[] T)
        {
            var resultArr = new int[T.Length];
            //for (int i = 0; i < T.Length; i++)
            //{
            //    var days = 0;
            //    for (int j = i + 1; j < T.Length; j++)
            //    {
            //        if (T[j] > T[i])
            //        {
            //            days = j - i;
            //            break;
            //        }
            //    }
            //    resultArr[i] = days;
            //}
            //return resultArr;
            Stack<int> stack = new Stack<int>();
            for (int i = T.Length - 1; i >= 0; --i)
            {
                while (stack.Count > 0 && T[i] >= T[stack.Peek()]) stack.Pop();
                resultArr[i] = stack.Count == 0 ? 0 : stack.Peek() - i;
                stack.Push(i);
            }

            return resultArr;
        }
    }
}
