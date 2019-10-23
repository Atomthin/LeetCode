using System;
using System.Collections.Generic;
using System.Linq;
using LeetCode.Core.Common;

namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            ListNode header = new ListNode(-1);
            header.next = head;
            ListNode cur = header;
            while (cur.next != null)
            {
                if (cur.next.val == val)
                {
                    cur.next = cur.next.next;
                }
                else
                {
                    cur = cur.next;
                }
            }
            return header.next;
        }
    }
}
