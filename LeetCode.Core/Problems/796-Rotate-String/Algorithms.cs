using System.Text;

namespace LeetCode.Core.Problems
{
    public partial class Algorithms
    {
        public bool RotateString(string A, string B)
        {
            if (A == B)
            {
                return true;
            }
            var result = false;
            var arr = A.ToCharArray();
            var count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                var temp = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    arr[j - 1] = arr[j];
                }
                arr[arr.Length - 1] = temp;
                var sb = new StringBuilder();
                foreach (var item in arr)
                {
                    sb.Append(item);
                }
                if (sb.ToString() == B)
                {
                    result = true;
                    break;
                }
                else
                {
                    i--;
                    sb.Clear();
                }
                count++;
                if (count == arr.Length)
                {
                    return false;
                }
            }
            return result;
        }
    }
}
