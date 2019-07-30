using System.Text;

namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        public string DefangIPaddr(string address)
        {
            var sb = new StringBuilder();
            foreach (var item in address)
            {
                if (item != '.')
                {
                    sb.Append(item);
                }
                else
                {
                    sb.Append("[.]");
                }
            }
            return sb.ToString();
        }
    }
}
