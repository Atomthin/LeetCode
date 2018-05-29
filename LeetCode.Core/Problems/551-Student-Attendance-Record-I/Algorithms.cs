namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        public bool CheckRecord(string s)
        {
            if (s.IndexOf("LLL") >= 0)
            {
                return false;
            }
            var ACount = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'A')
                {
                    ACount++;
                    if (ACount == 2)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
