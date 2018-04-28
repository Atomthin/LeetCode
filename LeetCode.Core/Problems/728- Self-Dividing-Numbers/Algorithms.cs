using System.Collections.Generic;

namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        public static List<int> SelfDividingNumbers(int left, int right)
        {
            var list = new List<int>();
            for (int i = left; i <= right; i++)
            {
                var flag = true;
                foreach (var item in i.ToString())
                {
                    if (item == '0')
                    {
                        flag = false;
                        break;
                    }
                    if (i % int.Parse(item.ToString()) != 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    list.Add(i);
                }
            }
            return list;
        }
    }
}
