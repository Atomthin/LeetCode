namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        public string ReverseString(string s)
        {
            var temp = new char[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                temp[i] = s[s.Length - 1 - i];
            }
            return new string(temp);
        }
    }
}
