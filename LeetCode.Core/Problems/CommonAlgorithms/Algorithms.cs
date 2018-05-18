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

        /// <summary>
        /// 冒泡排序
        /// 它重复地走访过要排序的数列，一次比较两个元素，如果他们的顺序错误就把他们交换过来。走访数列的工作是重复地进行直到没有再需要交换，也就是说该数列已经排序完成。
        /// 用了两个for循环，所以时间复杂度是 O（n²）
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int[] BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    var temp = 0;
                    if (arr[i] > arr[j])
                    {
                        temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            return arr;
        }

/// <summary>
        /// 快速排序法是采用递归的方式对待排序的数列进行若干次的操作,每次操作使得被操作的数列部分以某个元素为分界值分成两部分,一部分小于该分界值,另一部分大于该分界值.该分界值一般被称为"枢轴". 一般先以左边第一个数作为分界值，将数列按该分界值分成左右两部分，左边部分小于该分界值，右边部分大于该分界值，然后再对左右两部分做重复的操作，直到最后完成排序
        /// 平均时间复杂度 O(nlogn)
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
    }
}
