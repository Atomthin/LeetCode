using System.Collections.Generic;

namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        public int RomanToInt(string s)
        {
            var sum = 0;
            var dic = new Dictionary<string, int>()
            {
                {"V",5 },
                {"L",50 },
                {"D",500 },
                {"M",1000},
                {"IV",4 },
                {"IX",9},
                {"XL",40 },
                {"XC",90},
                {"CD",400 },
                {"CM",900}
            };
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'I')
                {
                    if (i + 1 < s.Length && (s[i + 1] == 'V' || s[i + 1] == 'X'))
                    {
                        sum += dic[s[i].ToString() + s[i + 1].ToString()];
                        i++;
                    }
                    else
                    {
                        sum += 1;
                    }
                    continue;
                }
                if (s[i] == 'X')
                {
                    if (i + 1 < s.Length && (s[i + 1] == 'L' || s[i + 1] == 'C'))
                    {
                        sum += dic[s[i].ToString() + s[i + 1].ToString()];
                        i++;
                    }
                    else
                    {
                        sum += 10;
                    }
                    continue;
                }
                if (s[i] == 'C')
                {
                    if (i + 1 < s.Length && (s[i + 1] == 'D' || s[i + 1] == 'M'))
                    {
                        sum += dic[s[i].ToString() + s[i + 1].ToString()];
                        i++;
                    }
                    else
                    {
                        sum += 100;
                    }
                    continue;
                }
                sum += dic[s[i].ToString()];
            }
            return sum;
        }
    }
}
