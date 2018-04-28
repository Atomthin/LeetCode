using System;
using System.Text;

namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        public bool DetectCapitalUse(string word)
        {
            var initValue = 0;
            var temp = false;
            for (int i = 0; i < word.Length; i++)
            {
                IsUpperCase(word[i], ref initValue);
                if (i == 0 && initValue == 1)
                {
                    temp = true;
                }
            }
            if (Math.Abs(initValue) == word.Length)
            {
                return true;
            }
            else if (Math.Abs(initValue) == word.Length - 2 && temp && initValue <= 0)
            {
                return true;
            }
            return false;
        }

        private void IsUpperCase(char c, ref int initValue)
        {
            var asciiCodeArr = Encoding.ASCII.GetBytes(c.ToString());
            if (asciiCodeArr[0] >= 65 && asciiCodeArr[0] <= 90)
            {
                initValue++;
                return;
            }
            initValue--;
            return;
        }
    }
}
