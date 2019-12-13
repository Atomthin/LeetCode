using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        public string RemoveDuplicates(string S)
        {
            var stack = new Stack<char>();
            foreach (var c in S)
            {
                if (stack.Count == 0 || stack.Peek() != c)
                {
                    stack.Push(c);
                }
                else
                {
                    stack.Pop();
                }
            }
            var sb = new StringBuilder();
            foreach (var item in stack.Reverse())
            {
                sb.Append(item);
            }
            return sb.ToString();
        }
    }
}
