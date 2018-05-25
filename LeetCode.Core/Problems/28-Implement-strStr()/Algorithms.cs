namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        /// <summary>
        /// 思路及时遍历字符串，如果找到needle存在haystack中就结束。
        /// </summary>
        /// <param name="haystack"></param>
        /// <param name="needle"></param>
        /// <returns></returns>
        public int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle))
            {
                return 0;
            }
            if (needle.Length > haystack.Length)
            {
                return -1;
            }
            if (haystack.Length == needle.Length)
            {
                if (haystack == needle)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            var index = -1;
            for (int i = 0; i < haystack.Length; i++)
            {
                for (int j = 0; j < needle.Length; j++)
                {
                    if (i + j >= haystack.Length || haystack[i + j] != needle[j])
                    {
                        index = -1;
                        break;
                    }
                    else
                    {
                        index = index < i && index != -1 ? index : i;
                    }
                }
                if (index != -1)
                {
                    return index;
                }
            }
            return index;
        }
    }
}
