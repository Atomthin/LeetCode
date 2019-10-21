using LeetCode.Core.Common;

namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        /// <summary>
        /// 笨办法，循环两遍，第一边把链表中的个数算出来，然后后面计算得到需要移除的元素的索引，在循环一遍，移除该元素
        /// 理论上应该可以用双指针的方法，再研究一下
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
            var tempIndex = 0;
            ListNode prev = head;
            ListNode delNode = head;
            while (tempIndex != removeIndex)
            {
                prev = delNode;
                delNode = delNode.next;
                tempIndex++;
            }
            prev.next = delNode.next;
            return head;
        }
    }
}
