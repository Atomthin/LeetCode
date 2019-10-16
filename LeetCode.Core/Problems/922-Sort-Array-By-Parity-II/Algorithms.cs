using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        public int[] SortArrayByParityII(int[] array)
        {
            var oddList = new List<int>(array.Length / 2);
            var evenList = new List<int>(array.Length / 2);
            var  tempList = new List<int>(array.Length);
            foreach (var t in array)
            {
                if (t % 2 == 0)
                {
                    oddList.Add(t);
                }
                if (t % 2 != 0)
                {
                    evenList.Add(t);
                }
            }
            for (int i = 0; i < array.Length/2; i++)
            {
                tempList.Add(oddList[i]);
                tempList.Add(evenList[i]);
            }
            return tempList.ToArray();
        }
    }
}
