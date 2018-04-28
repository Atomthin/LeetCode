using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        public IList<string> LetterCasePermutation(string S)
        {
            var set = new HashSet<string>
            {
                S
            };
            var arr = S.ToCharArray();
            var sb = new StringBuilder();
            for (int i = 0; i < arr.Length; i++)
            {
                if (Regex.IsMatch(arr[i].ToString(), "^[a-z]"))
                {
                    var temp = arr[i];
                    arr[i] = char.Parse(arr[i].ToString().ToUpper());
                    foreach (var item in arr)
                    {
                        sb.Append(item);
                    }
                    if (!set.Add(sb.ToString()))
                    {
                        continue;
                    }
                    arr[i] = temp;
                }
                if (Regex.IsMatch(arr[i].ToString(), "^[A-Z]"))
                {
                    var temp = arr[i];
                    arr[i] = char.Parse(arr[i].ToString().ToLower());
                    foreach (var item in arr)
                    {
                        sb.Append(item);
                    }
                    if (!set.Add(sb.ToString()))
                    {
                        continue;
                    }
                    arr[i] = temp;
                }
                sb.Clear();
            }
            return set.ToList();
        }
    }
}
