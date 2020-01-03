using System;
using LeetCode.Core.Common;

namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        /// <summary>
        /// 运用递归完成，注意递归边界条件
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
            {
                return root;
            }
            var tempNode = root.left;
            root.left = root.right;
            root.right = tempNode;
            root.left = InvertTree(root.left);
            root.right = InvertTree(root.right);
            return root;
        }
    }
}
