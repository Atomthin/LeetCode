using System.Collections.Generic;

namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        public IList<string> FizzBuzz(int n)
        {
            var list = new List<string>();
            for (int i = 1; i < n + 1; i++)
            {
                if (i % 15 == 0)
                {
                    list.Add("FizzBuzz");
                    continue;
                }
                var tempBool = false;
                if (i % 3 == 0)
                {
                    tempBool = true;
                    list.Add("Fizz");
                }
                if (i % 5 == 0)
                {
                    tempBool = true;
                    list.Add("Buzz");
                }
                if (!tempBool)
                {
                    list.Add(i.ToString());
                }
            }
            return list;
        }
    }
}
