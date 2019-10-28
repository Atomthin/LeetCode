using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using LeetCode.Core.Common;

namespace LeetCode.Core.DataStructure.LinkedList
{
    /** Initialize your data structure here. */
    public class MyLinkedList
    {
        private ListNode Node { get; set; }
        private int Count { get; set; } = 0;

        public MyLinkedList()
        {
            Node = null;
        }

        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {
            if (index < 0 || Node == null)
            {
                return -1;
            }
            var temp = 0;
            var curr = Node;
            while (temp != index)
            {
                curr = curr.next;
                if (curr == null)
                {
                    return -1;
                }
                temp++;
            }
            return curr.val;
        }

        /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            var curr = new ListNode(val);
            if (Node == null)
            {
                Node = curr;
            }
            else
            {
                curr.next = Node;
                Node = curr;
            }
            Count++;
        }

        /** Append a node of value val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            var foot = new ListNode(val);
            if (Node == null)
            {
                Node = foot;
                Count++;
                return;
            }
            var tempNode = Node;
            while (tempNode.next != null)
            {
                tempNode = tempNode.next;
            }
            tempNode.next = foot;
            Count++;
        }

        /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            if (index == Count)
            {
                AddAtTail(val);
                return;
            }
            if (index == 0 || index == -1)
            {
                AddAtHead(val);
            }
            if (index > 0)
            {
                var curr = new ListNode(val);
                ListNode prev = Node;
                ListNode next = Node;
                var temp = 0;
                while (temp != index)
                {
                    if (next == null)
                    {
                        return;
                    }
                    prev = next;
                    next = next.next;
                    temp++;
                }
                if (next != null)
                {
                    curr.next = next;
                    prev.next = curr;
                    Count++;
                }
            }
        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            var temp = 0;
            if (index == 0)
            {
                Node = Node.next;
                return;
            }
            ListNode prev = Node;
            var delNode = Node;
            while (temp != index)
            {
                prev = delNode;
                if (delNode == null)
                {
                    return;
                }
                delNode = delNode.next;
                temp++;
            }
            if (delNode == null)
            {
                return;
            }
            prev.next = delNode.next;
            Count--;
        }
    }
}
