using System.Linq;
using System.Text;

namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        public string ReverseString(string s)
        {
            var reverse = s.Reverse();
            StringBuilder sb = new StringBuilder();
            foreach (var item in reverse)
            {
                sb.Append(item);
            }
            return sb.ToString();
        }
    }
}
