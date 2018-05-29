namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        public int FirstUniqChar(string s)
        {
            int[] temp = new int[26];
            for (int i = 0; i < s.Length; i++)
                temp[s[i] - 'a']++;
            for (int i = 0; i < s.Length; i++)
            {
                if (temp[s[i] - 'a'] == 1)
                    return i;
            }
            return -1;
        }
    }
}
