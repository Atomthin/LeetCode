using System.Linq;

namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        public bool JudgeCircle(string moves)
        {
            var stepList = moves.Count();
            if (stepList % 2 != 0)
            {
                return false;
            }
            var x = 0;
            var y = 0;
            foreach (var item in moves)
            {
                if (item == 'U')
                {
                    x += 1;
                }
                if (item == 'D')
                {
                    x += -1;
                }
                if (item == 'L')
                {
                    y += 1;
                }
                if (item == 'R')
                {
                    y += -1;
                }
            }
            if (x == 0 && y == 0)
            {
                return true;
            }
            return false; ;
        }
    }
}
