namespace LeetCode.Core.Common
{
    public class BinarySearchTree
    {
        public TreeNode root;

        public BinarySearchTree()
        {
            root = null;
        }

        public void Insert(int num)
        {
            var node = new TreeNode(num);
            if (root == null)
            {
                root = node;
            }
            else
            {
                var current = root;
                while (true)
                {
                    //找到合适的位置存放
                    if (num < current.value)
                    {
                        if (current.left != null)
                            current = current.left;
                        else
                        {
                            current.left = node;
                            break;
                        }
                    }
                    else
                    {
                        if (current.right != null)
                            current = current.right;
                        else
                        {
                            current.right = node;
                            break;
                        }
                    }
                }
            }
        }

        public int GetMax()
        {
            var currentNode = root;
            while (currentNode.right != null)
            {
                currentNode = currentNode.right;
            }
            return currentNode.value;
        }

        public int GetMin()
        {
            var currentNode = root;
            while (currentNode.left != null)
            {
                currentNode = currentNode.left;
            }
            return currentNode.value;
        }

        public bool Find(int num)
        {
            var currentNode = root;
            while (currentNode != null)
            {
                if (num > currentNode.value)
                {
                    currentNode = currentNode.right;
                }
                else if (num < currentNode.value)
                {
                    currentNode = currentNode.left;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }

    }
}
