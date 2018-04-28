using System;
using System.Linq;
using System.Text;

namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        public string ReverseWords(string s)
        {
            var charArr = s.ToCharArray();
            var reverseChar = charArr.Reverse().ToArray();
            var sb = new StringBuilder();
            foreach (var item in reverseChar)
            {
                sb.Append(item);
            }
            var tempArr = sb.ToString().Split(' ');

            for (var i = 0; i < Math.Floor((double)tempArr.Length / 2); i++)
            {
                var temp = tempArr[i];
                tempArr[i] = tempArr[tempArr.Length - (i + 1)];
                tempArr[tempArr.Length - (i + 1)] = temp;
            }
            var sb2 = new StringBuilder();
            for (var i = 0; i < tempArr.Length; i++)
            {
                if (i != tempArr.Length - 1)
                {
                    sb2.Append(tempArr[i] + " ");
                }
                else
                {
                    sb2.Append(tempArr[i]);
                }
            }
            return sb2.ToString();
        }
    }
}
