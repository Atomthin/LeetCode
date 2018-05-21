using LeetCode.Core.Common;
using System.Collections.Generic;

namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        #region 二分查找
        /*
        二分查找：
            在一个已排序的数组seq中，使用二分查找v，假如这个数组的范围是[low...high]，我们要的v就在这个范围里。查找的方法是拿low到high的正中间的值，我们假设是m，来跟v相比，如果m>v，说明我们要查找的v在前数组seq的前半部，否则就在后半部。无论是在前半部还是后半部，将那部分再次折半查找，重复这个过程，知道查找到v值所在的地方。实现二分查找可以用循环，也可以用递归。
        时间复杂度：
            总共有n个元素，每次查找的区间大小就是n，n/2，n/4，…，n/2^k（接下来操作元素的剩余个数），其中k就是循环的次数。 由于n/2^k取整后>=1，即令n/2^k=1， 可得k=log2n,（是以2为底，n的对数），所以时间复杂度可以表示O()=O(logn)
        */
        /// <summary>
        /// 循环实现二分查找
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int BinarySearch(int[] arr, int target)
        {
            var left = 0;
            var right = arr.Length - 1;
            var middle = 0;
            while (left < right)
            {
                middle = (left + right) / 2;
                if (arr[middle] == target)
                {
                    return middle;
                }
                if (arr[middle] > target)
                {
                    right = middle;
                }
                else
                {
                    left = middle;
                }
            }
            return -1;
        }

        /// <summary>
        /// 递归实现二分查找
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="target"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public int BinarySearchRecursion(int[] arr, int target, int left, int right)
        {
            var middle = (left + right) / 2;
            if (arr[middle] == target)
            {
                return middle;
            }
            if (arr[middle] > target)
            {
                right = middle;
            }
            else
            {
                left = middle;
            }
            return BinarySearchRecursion(arr, target, left, right);
        }
        #endregion

        #region 排序

        #region 插入排序
        /// <summary>
        /// 直接插入排序（Straight Insertion Sort），每趟将一个元素，按其关键字大小插入到它前面已排序的子序列中，是的插入后的子序列仍然是排序的，依次重复，知道全部元素插入完毕。
        /// 用了两个for循环，所以时间复杂度是 O(n²)(最坏情况与随机情况)，O(n)(最好情况，已排序) 需要一个辅助变量用于交换两个元素，空间复杂度是O(1) 稳定
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int[] StraightInsertionSort(int[] arr)
        {
            //循环每个元素，从1开始的原因是任务第一个元素是排好序的
            for (int i = 1; i < arr.Length; i++)
            {
                var temp = arr[i];
                int j = 0;
                //循环已经排好序的子序列，找到合适的位置插入新元素
                for (j = i - 1; j >= 0 && temp < arr[j]; j--)
                {
                    arr[j + 1] = arr[j];
                }
                arr[j + 1] = temp;
            }
            return arr;
        }

        /// <summary>
        /// 希尔排序(Shell's Sort)是插入排序的一种又称“缩小增量排序”（Diminishing Increment Sort），是直接插入排序算法的一种更高效的改进版本。
        /// 时间复杂度取决于具体的增量序列，需要一个辅助变量用于交换两个元素，空间复杂度O(1) 不稳定
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int[] ShellSort(int[] arr)
        {
            //以增量delta变化控制进行若干趟扫描，delta的数值为序列长度n的一般，以后逐趟减半，直至为1
            for (int delta = arr.Length / 2; delta > 0; delta /= 2)
            {
                //进行一趟扫描，序列分为delta组，每组由相距delta远的n/delta个元素组成，每组元素分别进行直接插入排序
                for (int i = delta; i < arr.Length; i++)
                {
                    var temp = arr[i];
                    var j = 0;
                    //进行一组直接插入排序，将一个元素arr[i]插入其所在组前面已经排序的子序列中
                    for (j = i - delta; j >= 0 && temp < arr[j]; j -= delta)
                    {
                        arr[j + delta] = arr[j];
                    }
                    arr[j + delta] = temp;
                }
            }
            return arr;
        }
        #endregion

        #region 交换排序

        /// <summary>
        /// 冒泡排序
        /// 它重复地走访过要排序的数列，一次比较两个元素，如果他们的顺序错误就把他们交换过来。走访数列的工作是重复地进行直到没有再需要交换，也就是说该数列已经排序完成。
        /// 用了两个for循环，所以时间复杂度是 O(n²)(最坏)，O(1)(最好，已经排序) 需要一个辅助变量用于交换两个元素，所以空间复杂度O(1) 稳定
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int[] BubbleSort(int[] arr)
        {
            var exchange = true;
            for (int i = 0; i < arr.Length && exchange; i++)
            {
                exchange = false;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        var temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                        exchange = true;
                    }
                }
            }
            return arr;
        }

        /// <summary>
        /// 快速排序
        /// 采用递归的方式对待排序的数列进行若干次的操作,每次操作使得被操作的数列部分以某个元素为分界值分成两部分,一部分小于该分界值,另一部分大于该分界值.该分界值一般被称为"枢轴". 一般先以左边第一个数作为分界值，将数列按该分界值分成左右两部分，左边部分小于该分界值，右边部分大于该分界值，然后再对左右两部分做重复的操作，直到最后完成排序
        /// 平均时间复杂度 O(nlogn)，最坏情况是O(n²) 快速排序在递归调用过程中，需要使用栈保存参数，栈锁占用的空间与递归调用的次数有关，最好情况下空间复杂度是O(log2n),最坏情况下是O(n),平均是O(log2n) 不稳定
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public int[] QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                var i = Division(arr, left, right);
                QuickSort(arr, i + 1, right);
                QuickSort(arr, left, i - 1);
            }
            return arr;
        }
        private int Division(int[] arr, int left, int right)
        {
            var flag = arr[left];
            while (left < right)
            {
                if (flag > arr[left + 1])
                {
                    arr[left] = arr[left + 1];
                    arr[left + 1] = flag;
                    left++;
                }
                else
                {
                    var temp = arr[right];
                    arr[right] = arr[left + 1];
                    arr[left + 1] = temp;
                    right--;
                }
            }
            return left;
        }
        #endregion

        #region 选择排序
        /// <summary>
        /// 直接选择排序(Straight Select Sort)，它的基本思想是：第一次从R[0]~R[n-1]中选取最小值，与R[0]交换，第二次从R[1]~R[n-1]中选取最小值，与R[1]交换，....，第i次从R[i-1]~R[n-1]中选取最小值，与R[i-1]交换，.....，第n-1次从R[n-2]~R[n-1]中选取最小值，与R[n-2]交换，总共通过n-1次，得到一个按排序码从小到大排列的有序序列
        /// 两个for循环，时间复杂度是O(n²)，需要一个辅助变量用于交换两个元素，所以空间复杂度O(1) 不稳定
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int[] StraightSelectSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                var min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    var temp = arr[i];
                    arr[i] = arr[min];
                    arr[min] = temp;
                }
            }
            return arr;
        }

        /// <summary>
        /// 堆排序(Heapsort)是指利用堆积树（堆）这种数据结构所设计的一种排序算法，它是选择排序的一种。可以利用数组的特点快速定位指定索引的元素。堆分为大根堆和小根堆，是完全二叉树。大根堆的要求是每个节点的值都不大于其父节点的值，即A[PARENT[i]] >= A[i]。在数组的非降序排序中，需要使用的就是大根堆，因为根据大根堆的要求可知，最大的值一定在堆顶。
        /// 将一个序列调整为堆的时间复杂度为O(log2n)，因此堆排序的时间复杂度为O(nlogn)。堆排序的控件复杂度为O(1)。 不稳定
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int[] HeapSort(int[] arr)
        {
            var n = arr.Length;
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Shift(arr, i, n);
            }
            for (int i = n - 1; i > 0; i--)
            {
                var temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;
                Shift(arr, 0, i - 1);
            }
            return arr;
        }

        private void Shift(int[] arr, int begin, int end)
        {
            var i = begin;
            var j = 2 * i + 1;
            var temp = arr[i];
            while (j <= end)
            {
                if (j < end && arr[j] > arr[j + 1])
                {
                    j++;
                }
                if (temp > arr[j])
                {
                    arr[i] = arr[j];
                    i = j;
                    j = 2 * i + 1;
                }
                else
                {
                    break;
                }
            }
            arr[i] = temp;
        }
        #endregion

        /// <summary>
        /// 归并排序（MERGE-SORT）是利用归并的思想实现的排序方法，该算法采用经典的分治（divide-and-conquer）策略（分治法将问题分(divide)成一些小的问题然后递归求解，而治(conquer)的阶段则将分的阶段得到的各答案"修补"在一起，即分而治之)。归并排序是稳定排序，它也是一种十分高效的排序，能利用完全二叉树特性的排序一般性能都不会太差。每次合并操作的平均时间复杂度为O(n)，而完全二叉树的深度为|log2n|。总的平均时间复杂度为O(nlogn)。而且，归并排序的最好，最坏，平均时间复杂度均为O(nlogn)。
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int[] MergeSort(int[] arr)
        {
            int[] temp = new int[arr.Length];//在排序前，先建好一个长度等于原数组长度的临时数组，避免递归中频繁开辟空间
            Sort(arr, 0, arr.Length - 1, temp);
            return arr;
        }
        private static void Sort(int[] arr, int left, int right, int[] temp)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                Sort(arr, left, mid, temp);//左边归并排序，使得左子序列有序
                Sort(arr, mid + 1, right, temp);//右边归并排序，使得右子序列有序
                Merge(arr, left, mid, right, temp);//将两个有序子数组合并操作
            }
        }
        private static void Merge(int[] arr, int left, int mid, int right, int[] temp)
        {
            int i = left;//左序列指针
            int j = mid + 1;//右序列指针
            int t = 0;//临时数组指针
            while (i <= mid && j <= right)
            {
                if (arr[i] <= arr[j])
                {
                    temp[t++] = arr[i++];
                }
                else
                {
                    temp[t++] = arr[j++];
                }
            }
            while (i <= mid)
            {//将左边剩余元素填充进temp中
                temp[t++] = arr[i++];
            }
            while (j <= right)
            {//将右序列剩余元素填充进temp中
                temp[t++] = arr[j++];
            }
            t = 0;
            //将temp中的元素全部拷贝到原数组中
            while (left <= right)
            {
                arr[left++] = temp[t++];
            }
        }

        #endregion

        #region 二叉树遍历

        /// <summary>
        /// 先序遍历
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public List<int> DLR(TreeNode node)
        {
            if (node == null)
                return null;
            var list = new List<int>();
            list.Add(node.value);
            if (node.left != null)
            {
                list.AddRange(DLR(node.left));
            }
            if (node.right != null)
            {
                list.AddRange(DLR(node.right));
            }
            return list;
        }

        /// <summary>
        /// 中序遍历
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public List<int> LDR(TreeNode node)
        {
            if (node == null)
                return null;
            var list = new List<int>();
            if (node.left != null)
            {
                list.AddRange(LDR(node.left));
            }
            list.Add(node.value);
            if (node.right != null)
            {
                list.AddRange(LDR(node.right));
            }
            return list;
        }

        /// <summary>
        /// 后序遍历
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public List<int> LRD(TreeNode node)
        {
            if (node == null)
                return null;
            var list = new List<int>();
            if (node.left != null)
            {
                list.AddRange(LRD(node.left));
            }
            if (node.right != null)
            {
                list.AddRange(LRD(node.right));
            }
            list.Add(node.value);
            return list;
        }

        /// <summary>
        /// 层序遍历
        /// 借助队列进行
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public List<int> LevelOrder(TreeNode node)
        {
            if (node == null)
                return null;
            var list = new List<int>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(node);
            while (queue.Count > 0)
            {
                var temp = queue.Dequeue();
                list.Add(temp.value);
                if (temp.left != null)
                {
                    queue.Enqueue(temp.left);
                }
                if (temp.right != null)
                {
                    queue.Enqueue(temp.right);
                }
            }
            return list;
        }
        #endregion
    }
}