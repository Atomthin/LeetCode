using LeetCode.Core.Common;

namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        /// <summary>
        /// 笨办法，先进行一遍循环，算出链表的长度，然后通过计算得知需要删除的节点的索引，再通过一遍循环删除节点
        /// 应该能通过双指针的办法进行，需要进一步的思考
        /// </summary>
        /// <param name="head"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var count = 1;
            ListNode node = head;
            while (node.next != null)
            {
                node = node.next;
                count++;
            }
            if (count == n)
            {
                return head.next;
            }
            var removeIndex = count - n;
            ListNode prev = head;
            node = head;
            while (removeIndex > 0)
            {
                prev = node;
                node = node.next;
                removeIndex--;
            }
            prev.next = node.next;
            return head;
        }
    }
}
