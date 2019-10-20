using LeetCode.Core.Common;

namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        public ListNode DetectCycle(ListNode head)
        {
            if (head?.next == null)
            {
                return null;
            }
            ListNode slowNode = head;
            ListNode fastNode = head;
            ListNode cross = null;
            while (slowNode != null && fastNode?.next != null)
            {
                slowNode = slowNode.next;
                fastNode = fastNode.next.next;
                if (slowNode == fastNode)
                {
                    cross = fastNode;
                    break;
                }
            }

            if (cross == null)
            {
                return null;
            }

            ListNode start = head;
            while (start != cross)
            {
                start = start.next;
                cross = cross.next;
            }
            return cross;
        }
    }
}
