using LeetCode.Core.Common;

namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        public bool HasCycle(ListNode head)
        {
            if (head?.next == null)
            {
                return false;
            }
            ListNode slowNode = head;
            ListNode fastNode = head.next;
            while (slowNode != fastNode)
            {
                if (fastNode?.next == null)
                {
                    return false;
                }
                slowNode = slowNode.next;
                fastNode = fastNode.next.next;
            }
            return true;
        }
    }
}
