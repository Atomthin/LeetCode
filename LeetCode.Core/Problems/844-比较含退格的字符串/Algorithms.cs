using System.Collections.Generic;

namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        /// <summary>
        /// 两个栈解决问题
        /// </summary>
        /// <param name="S"></param>
        /// <param name="T"></param>
        /// <returns></returns>
        public bool BackspaceCompare(string S, string T)
        {
            var stackS = new Stack<char>();
            var stackT = new Stack<char>();
            foreach (var item in S)
            {
                if (item == '#')
                {
                    if (stackS.Count > 0)
                    {
                        stackS.Pop();
                    }
                }
                else
                {
                    stackS.Push(item);
                }
            }
            foreach (var item in T)
            {
                if (item == '#')
                {
                    if (stackT.Count > 0)
                    {
                        stackT.Pop();
                    }
                }
                else
                {
                    stackT.Push(item);
                }
            }
            if (stackS.Count != stackT.Count)
            {
                return false;
            }
            for (var i = 0; i < stackS.Count; i++)
            {
                if (stackS.Pop() != stackT.Pop())
                {
                    return false;
                }
            }
            return true;
        }
    }
}
