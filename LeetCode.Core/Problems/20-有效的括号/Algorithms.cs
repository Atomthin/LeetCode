using System.Collections.Generic;

namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        /// <summary>
        /// 借用栈这个数据结构完成，从左到右依次扫描字符串。当扫描到左括号时，则将其压入栈中；当扫描到右括号时，从栈顶取出一个左括号。如果能够匹配，比如“(”跟“)”匹配，“[”跟“]”匹配，“{”跟“}”匹配，则继续扫描剩下的字符串。如果扫描的过程中，遇到不能配对的右括号，或者栈中没有数据，则说明为非法格式。
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool IsValid(string s)
        {
            var stack = new Stack<char>();
            foreach (var item in s)
            {
                if (item == '{' || item == '(' || item == '[')
                {
                    stack.Push(item);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    if (item + stack.Peek() == 81 || item + stack.Peek() == 184 || item + stack.Peek() == 248)
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }
    }
}
