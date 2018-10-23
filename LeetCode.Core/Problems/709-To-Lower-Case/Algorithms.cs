using System.Text;

namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        public string ToLowerCase(string str)
        {
            var charArr = str.ToCharArray();
            var sb = new StringBuilder();
            foreach (var item in charArr)
            {
                var temp = item;
                if (item >= 65 && item <= 90)
                {
                    temp = (char)(item + 32);
                }
                sb.Append(temp);
            }
            return sb.ToString();
        }
    }
}
