using System;
using LeetCode.Core.Common;
using LeetCode.Core.Problems;
using System.Collections.Generic;
using LeetCode.Core.DataStructure.LinkedList;
using Xunit;

namespace LeetCode.Test
{
    public class UnitTest
    {
        #region UT
        Algorithms al = new Algorithms();
        [Fact]
        public void TwoSum()
        {
            Assert.Equal(new int[] { 0, 1 }, al.TwoSum(new int[] { 2, 7, 11, 15 }, 9));
            Assert.NotEqual(new int[] { 1, 3 }, al.TwoSum(new int[] { 2, 7, 11, 15 }, 18));
        }

        [Fact]
        public void ShortestToChar()
        {
            Assert.Equal(new int[] { 3, 2, 1, 0, 1, 0, 0, 1, 2, 2, 1, 0 }, al.ShortestToChar("loveleetcode", 'e'));
            Assert.Equal(new int[] { 2, 1, 0, 0, 1 }, al.ShortestToChar("skeet", 'e'));
        }

        [Fact]
        public void IsToeplitzMatrix()
        {
            Assert.True(al.IsToeplitzMatrix(new int[,] { { 1, 2, 3, 4 }, { 5, 1, 2, 3 }, { 9, 5, 1, 2 } }));
            Assert.False(al.IsToeplitzMatrix(new int[,] { { 1, 2 }, { 2, 2 } }));
        }

        [Fact]
        public void CountPrimeSetBits()
        {
            Assert.Equal(4, al.CountPrimeSetBits(6, 10));
            Assert.Equal(23, al.CountPrimeSetBits(842, 888));
            Assert.Equal(21, al.CountPrimeSetBits(567, 607));
        }

        [Fact]
        public void ReverseString()
        {
            Assert.Equal("ABC", al.ReverseString("CBA"));
        }

        [Fact]
        public void MaxDepth()
        {
            var treeNode = new TreeNode(3)
            {
                left = new TreeNode(9),
                right = new TreeNode(20)
            };
            treeNode.right.left = new TreeNode(7);
            treeNode.right.right = new TreeNode(15);
            Assert.Equal(3, al.MaxDepth(treeNode));
        }

        [Fact]
        public void RotatedDigits()
        {
            Assert.Equal(247, al.RotatedDigits(857));
        }

        [Fact]
        public void StrStr()
        {
            Assert.Equal(-1, al.StrStr("mississippi", "sippia"));
        }

        [Fact]
        public void FirstUniqChar()
        {
            Assert.Equal(2, al.FirstUniqChar("loveleetcode"));
        }

        [Fact]
        public void CheckRecord()
        {
            Assert.True(al.CheckRecord("PPALLP"));
        }

        [Fact]
        public void PeakIndexInMountainArray()
        {
            Assert.Equal(1, al.PeakIndexInMountainArray(new int[] { 0, 2, 1, 0 }));
        }

        [Fact]
        public void ToLowerCase()
        {
            Assert.Equal("hello", al.ToLowerCase("HelLo"));
        }

        [Fact]
        public void SortArrayByParityII()
        {
            Assert.Equal(new int[] { 2, 3, 4, 5, 6, 7 }, al.SortArrayByParityII(new int[] { 3, 2, 4, 5, 6, 7 }));
        }

        [Fact]
        public void IsPalindrome()
        {
            Assert.Equal(true, al.IsPalindrome(1221));
            Assert.Equal(false, al.IsPalindrome(-1221));
            Assert.Equal(true, al.IsPalindrome(1234321));
        }

        [Fact]
        public void MaxProfit()
        {
            Assert.Equal(5, al.MaxProfit(new[] { 7, 1, 5, 3, 6, 4 }));
            Assert.Equal(3, al.MaxProfit(new[] { 2, 1, 4 }));
            Assert.Equal(0, al.MaxProfit(new[] { 7, 6, 4, 3, 1 }));
            Assert.Equal(4, al.MaxProfit(new[] { 3, 2, 6, 5, 0, 3 }));
        }

        [Fact]
        public void IsPalindromeListNode()
        {
            Assert.Equal(true, al.IsPalindrome(new ListNode(0) { next = new ListNode(0) }));
        }

        [Fact]
        public void FindDiagonalOrder()
        {
            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Assert.Equal(new int[] { 1, 2, 4, 7, 5, 3, 6, 8, 9 }, al.FindDiagonalOrder(matrix));
        }

        [Fact]
        public void MiddleNode()
        {
            var ddd = new ListNode(3) { next = new ListNode(4) { next = new ListNode(5) } };
            Assert.Equal(ddd, al.MiddleNode(new ListNode(1) { next = new ListNode(2) { next = new ListNode(3) { next = new ListNode(4) { next = new ListNode(5) } } } }));
        }

        [Fact]
        public void IsValid()
        {
            Assert.True(al.IsValid("()"));
        }

        #endregion

        #region CommonAlgorithms
        [Fact]
        public void BinarySearch()
        {
            Assert.Equal(5, al.BinarySearch(new int[] { 1, 2, 3, 4, 9, 10, 65, 89, 100, 105, 200 }, 10));
            Assert.Equal(5, al.BinarySearchRecursion(new int[] { 1, 2, 3, 4, 9, 10, 65, 89, 100, 105, 200 }, 10, 0, 10));
        }

        [Fact]
        public void StraightInsertionSort()
        {
            Assert.Equal(new int[] { 1, 3, 10, 30, 100, 200, 500, 1000, 2000 }, al.StraightInsertionSort(new int[] { 1, 3, 1000, 2000, 30, 10, 500, 200, 100 }));
        }

        [Fact]
        public void ShellSort()
        {
            Assert.Equal(new int[] { 1, 3, 10, 30, 100, 200, 500, 1000, 2000 }, al.StraightInsertionSort(new int[] { 1, 3, 1000, 2000, 30, 10, 500, 200, 100 }));
        }

        [Fact]
        public void BubbleSort()
        {
            Assert.Equal(new int[] { 1, 3, 10, 30, 100, 200, 500, 1000, 2000 }, al.BubbleSort(new int[] { 1, 3, 1000, 2000, 30, 10, 500, 200, 100 }));
        }

        [Fact]
        public void QuickSort()
        {
            Assert.Equal(new int[] { 1, 3, 10, 30, 100, 200, 500, 1000, 2000 }, al.QuickSort(new int[] { 1, 3, 1000, 2000, 30, 10, 500, 200, 100 }, 0, 8));
        }

        [Fact]
        public void StraightSelectSort()
        {
            Assert.Equal(new int[] { 1, 3, 10, 30, 100, 200, 500, 1000, 2000 }, al.StraightSelectSort(new int[] { 1, 3, 1000, 2000, 30, 10, 500, 200, 100 }));
        }

        [Fact]
        public void HeapSort()
        {
            Assert.Equal(new int[] { 2000, 1000, 500, 200, 100, 30, 10, 3, 1 }, al.HeapSort(new int[] { 1, 3, 1000, 2000, 30, 10, 500, 200, 100 }));
        }

        [Fact]
        public void MergeSort()
        {
            Assert.Equal(new int[] { 1, 3, 10, 30, 100, 200, 500, 1000, 2000 }, al.MergeSort(new int[] { 1, 3, 1000, 2000, 30, 10, 500, 200, 100 }));
        }

        [Fact]
        public void DLR()
        {
            var treeNode = new TreeNode(3)
            {
                left = new TreeNode(9),
                right = new TreeNode(20)
            };
            treeNode.right.left = new TreeNode(7);
            treeNode.right.right = new TreeNode(15);
            Assert.Equal(new List<int> { 3, 9, 20, 7, 15 }, al.DLR(treeNode));
        }

        [Fact]
        public void LDR()
        {
            var treeNode = new TreeNode(3)
            {
                left = new TreeNode(9),
                right = new TreeNode(20)
            };
            treeNode.right.left = new TreeNode(7);
            treeNode.right.right = new TreeNode(15);
            Assert.Equal(new List<int> { 9, 3, 7, 20, 15 }, al.LDR(treeNode));
        }

        [Fact]
        public void LRD()
        {
            var treeNode = new TreeNode(3)
            {
                left = new TreeNode(9),
                right = new TreeNode(20)
            };
            treeNode.right.left = new TreeNode(7);
            treeNode.right.right = new TreeNode(15);
            Assert.Equal(new List<int> { 9, 7, 15, 20, 3 }, al.LRD(treeNode));
        }

        [Fact]
        public void LevelOrder()
        {
            var treeNode = new TreeNode(3)
            {
                left = new TreeNode(9),
                right = new TreeNode(20)
            };
            treeNode.right.left = new TreeNode(7);
            treeNode.right.right = new TreeNode(15);
            Assert.Equal(new List<int> { 3, 9, 20, 7, 15 }, al.LevelOrder(treeNode));
        }

        [Fact]
        public void CtorBinarySearchTreeAndLDR()
        {
            var arr = new int[] { 3, 9, 20, 7, 15 };
            var bst = new BinarySearchTree();
            foreach (var item in arr)
            {
                bst.Insert(item);
            }
            Assert.Equal(new List<int> { 3, 7, 9, 15, 20 }, al.LDR(bst.root));
        }

        [Fact]
        public void CtorBinarySearchTreeAndGetMax()
        {
            var arr = new int[] { 3, 9, 20, 7, 15 };
            var bst = new BinarySearchTree();
            foreach (var item in arr)
            {
                bst.Insert(item);
            }
            Assert.Equal(20, bst.GetMax());
        }

        [Fact]
        public void CtorBinarySearchTreeAndGetMin()
        {
            var arr = new int[] { 3, 9, 20, 7, 15 };
            var bst = new BinarySearchTree();
            foreach (var item in arr)
            {
                bst.Insert(item);
            }
            Assert.Equal(3, bst.GetMin());
        }

        [Fact]
        public void CtorBinarySearchTreeAndFind()
        {
            var arr = new int[] { 3, 9, 20, 7, 15 };
            var bst = new BinarySearchTree();
            foreach (var item in arr)
            {
                bst.Insert(item);
            }
            Assert.True(bst.Find(9));
        }

        [Fact]
        public void IsOneBitCharacter()
        {
            Assert.True(al.IsOneBitCharacter(new int[] { 0 }));
            Assert.False(al.IsOneBitCharacter(new int[] { 1, 1, 1, 0 }));
        }

        [Fact]
        public void LargeGroupPositions()
        {
            Assert.Equal(new List<IList<int>> { new List<int> { 3, 6 } }, al.LargeGroupPositions("abbxxxxzzy"));
            Assert.Equal(new List<IList<int>> { new List<int> { 0, 2 } }, al.LargeGroupPositions("aaa"));
        }

        [Fact]
        public void MostCommonWord()
        {
            Assert.Equal("ball", al.MostCommonWord("Bob hit a ball, the hit BALL flew far after it was hit.", new string[] { "hit" }));
        }

        [Fact]
        public void RomanToInt()
        {
            Assert.Equal(58, al.RomanToInt("LVIII"));
        }

        [Fact]
        public void PivotIndex()
        {
            Assert.Equal(3, al.PivotIndex(new[] { 1, 7, 3, 6, 5, 6 }));
            Assert.Equal(2, al.PivotIndex(new[] { -1, -1, -1, -1, -1, 0 }));
        }

        [Fact]
        public void RemoveDuplicates()
        {
            Assert.Equal("ca", al.RemoveDuplicates("abbaca"));
        }
        #endregion

        #region DataStruceure
        MyLinkedList linkedList = new MyLinkedList();
        [Fact]
        public void MyLinkedList()
        {
            linkedList.AddAtIndex(0, 10);
            linkedList.AddAtIndex(0, 20);
            linkedList.AddAtIndex(1, 30);
            Assert.Equal(20, linkedList.Get(0));
        }


        #endregion
    }
}
