using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        public int CalPoints(string[] ops)
        {
            Stack<int> sta = new Stack<int>();
            var score = 0;
            foreach (var item in ops)
            {
                if (Regex.IsMatch(item, @"^[-]?\d*$"))
                {
                    sta.Push(int.Parse(item));
                    score += int.Parse(item);
                }
                else if (item == "+")
                {
                    if (sta.Count >= 2)
                    {
                        var tempScore = 0;
                        var tempArr = sta.Reverse().ToArray();
                        for (int i = tempArr.Length - 1; i >= tempArr.Length - 2; i--)
                        {
                            tempScore += tempArr[i];
                        }
                        score += tempScore;
                        sta.Push(tempScore);
                    }
                    else
                    {
                        score += sta.Peek();
                    }
                }
                else if (item == "D")
                {
                    score += 2 * sta.Peek();
                    sta.Push(2 * sta.Peek());
                }
                else if (item == "C")
                {
                    score -= sta.Peek();
                    sta.Pop();
                }
            }
            return score;
        }
    }
}
