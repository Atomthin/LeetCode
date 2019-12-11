using System;
using LeetCode.Core.Common;

namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        /// <summary>
        /// 纯数组形式实现栈，并没有用stack本身来实现
        /// </summary>
        public class MinStack
        {
            private int _currentSize = 4;
            private int _count = 0;
            private int _min = int.MaxValue;
            private int[] Arr { get; set; }

            public MinStack()
            {
                Arr = new int[4];
            }

            public void Push(int x)
            {
                if (x < _min)
                {
                    _min = x;
                }
                if (_count >= _currentSize)
                {
                    _currentSize *= 2;
                    var tempArr = new int[_currentSize];
                    for (var i = 0; i < Arr.Length; i++)
                    {
                        tempArr[i] = Arr[i];
                    }
                    Arr = tempArr;
                    Arr[_count] = x;
                }
                else
                {
                    if (Arr == null)
                    {
                        Arr = new int[_currentSize];
                    }
                    Arr[_count] = x;
                }
                _count++;
            }

            public void Pop()
            {
                _count -= 1;
                if (_count <= 0)
                {
                    _count = 0;
                    Arr = null;
                    _currentSize = 4;
                    _min = int.MaxValue;
                    return;
                }
                var dropValue = Arr[_count];
                var tempArr = new int[_count];
                if (dropValue == _min)
                {
                    _min = int.MaxValue;
                }
                for (var i = 0; i < _count; i++)
                {
                    if (Arr[i] < _min)
                    {
                        _min = Arr[i];
                    }
                    tempArr[i] = Arr[i];
                }
                Arr = tempArr;
                _currentSize = _count;
            }

            public int Top()
            {
                var top = Arr[_count - 1];
                return top;
            }

            public int GetMin()
            {
                return _min;
            }
        }
    }
}
