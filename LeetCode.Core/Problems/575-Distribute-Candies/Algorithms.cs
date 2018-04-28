using System.Collections.Generic;

namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        public int DistributeCandies(int[] candies)
        {
            var hashSet = new HashSet<int>();
            foreach (var item in candies)
            {
                if (!hashSet.Contains(item))
                {
                    hashSet.Add(item);
                }
            }
            var setCount = hashSet.Count;
            var halfNum = candies.Length / 2;
            if (setCount <= halfNum)
            {
                return setCount;
            }
            else
            {
                return halfNum;
            }
        }
    }
}
