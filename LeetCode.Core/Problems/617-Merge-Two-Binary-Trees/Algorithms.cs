using LeetCode.Core.Common;

namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            if (t1 == null && t2 == null)
            {
                return null;
            }
            if (t1 == null && t2 != null)
            {

                return t2;
            }
            if (t1 != null && t2 == null)
            {

                return t1;
            }
            if (t1 != null && t2 != null)
            {
                t1.value += t2.value;
                t1.left = MergeTrees(t1.left, t2.left);
                t1.right = MergeTrees(t1.right, t2.right);
            }
            return t1;
        }
    }
}
