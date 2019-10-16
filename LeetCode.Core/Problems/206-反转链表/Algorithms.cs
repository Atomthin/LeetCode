using System;
using System.Collections.Generic;
using System.Linq;
using LeetCode.Core.Common;

namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            ListNode curr = head;
            while (curr != null)
            {
                var nextTemp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = nextTemp;
            }

            return prev;
        }

    }
}
