using System;
using LeetCode.Core.Common;

namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        /// <summary>
        /// 思想很很简单，用2个指针，一个low，一个fast，fast是low的2倍，所以可以达到2分链表的效果
        ///，在移动指针时同时对前半部分链表进行反转。最后直接比较被分开的2个链表
        /// 因为不能改变当前slow的next，不然就无法跳到下一个元素，所以这里用pre和prepre实现指针的反转
        /// 时间复杂度：第一个循环O(n/2)，第2个循环O(n/2)
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public bool IsPalindrome(ListNode head)
        {
            if (head == null || head.next == null) return true;
            ListNode slow = head, fast = head.next, pre = null, prepre = null;
            while (fast != null && fast.next != null)
            {
                //反转前半段链表
                pre = slow;
                slow = slow.next;
                fast = fast.next.next;
                //先移动指针再来反转
                pre.next = prepre;
                prepre = pre;
            }
            ListNode p2 = slow.next;
            slow.next = pre;
            ListNode p1 = fast == null ? slow.next : slow;
            while (p1 != null)
            {
                if (p1.val != p2.val)
                    return false;
                p1 = p1.next;
                p2 = p2.next;
            }
            return true;
        }
    }
}
