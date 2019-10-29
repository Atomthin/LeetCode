using LeetCode.Core.Common;

namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        /// <summary>
        /// 数学思路，直接用加法思路
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode p1 = l1;
            ListNode p2 = l2;
            ListNode dummyHead = new ListNode(0);
            ListNode curr = dummyHead;
            var carry = 0;
            while (p1 != null || p2 != null)
            {
                int x = (p1 != null) ? p1.val : 0;
                int y = (p2 != null) ? p2.val : 0;
                int sum = carry + x + y;
                carry = sum / 10;
                curr.next = new ListNode(sum % 10);
                curr = curr.next;
                if (p1 != null) p1 = p1.next;
                if (p2 != null) p2 = p2.next;
            }
            if (carry > 0)
            {
                curr.next = new ListNode(carry);
            }
            return dummyHead.next;
        }
    }
}
