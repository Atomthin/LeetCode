using System.Collections.Generic;

namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        public IList<IList<int>> LargeGroupPositions(string S)
        {
            var res = new List<IList<int>>();
            if (S.Length < 3)
            {
                return res;
            }
            var count = 1;
            char temp = S[0];
            for (int i = 1; i < S.Length; i++)
            {
                if (temp == S[i])
                {
                    count++;
                }
                else
                {
                    temp = S[i];
                    count = 1;
                }
                if (count >= 3)
                {
                    if (i + 1 < S.Length)
                    {
                        if (S[i + 1] != temp)
                        {
                            res.Add(new List<int> { i - count < 0 ? 0 : i - count + 1, i });
                        }
                        continue;
                    }
                    else
                    {
                        res.Add(new List<int> { i - count < 0 ? 0 : i - count + 1, i });
                    }
                }
            }
            return res;
        }
    }
}
