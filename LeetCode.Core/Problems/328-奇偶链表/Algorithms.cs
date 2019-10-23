using System;
using System.Collections.Generic;
using System.Linq;
using LeetCode.Core.Common;

namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        /// <summary>
        /// 奇偶两个链表，分别插入，最后再把偶链表插入到奇链表的后面即可
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public ListNode OddEvenList(ListNode head)
        {
            if (head == null)
                return null;
            ListNode nodeA = head;
            ListNode nodeB = head.next;
            ListNode p1 = nodeA;
            ListNode p2 = nodeB;

            while (p2?.next != null)
            {
                p1.next = p1.next.next;
                p2.next = p2.next.next;
                p1 = p1.next;
                p2 = p2.next;
            }

            p1.next = nodeB;
            return nodeA;
        }
    }
}
