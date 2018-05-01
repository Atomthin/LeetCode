using System.Linq;

namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        public int[] ShortestToChar(string S, char C)
        {
            var arr = new int[S.Length];
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == C)
                {
                    arr[i] = 0;
                    continue;
                }
                else
                {
                    var partStr1 = S.Substring(0, i + 1);
                    var partStr2 = S.Substring(i, S.Length - i);
                    var index1 = partStr1.Reverse().ToList().FindIndex(m => m == C);
                    var index2 = partStr2.IndexOf(C);
                    if (index1 > 0 && index2 > 0)
                    {
                        arr[i] = index1 < index2 ? index1 : index2;
                    }
                    else
                    {
                        if (index1 > 0)
                        {
                            arr[i] = index1;
                        }
                        if (index2 > 0)
                        {
                            arr[i] = index2;
                        }
                    }
                }
            }
            return arr;
        }
    }
}
