using System.Collections.Generic;

namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        public int NumJewelsInStones(string J, string S)
        {
            var count = 0;
            var set = new HashSet<char>(J);
            foreach (var item in S)
            {
                if (set.Contains(item))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
