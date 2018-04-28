using LeetCode.Core.Problems;
using Xunit;

namespace LeetCode.Test
{
    public class UnitTest
    {
        [Fact]
        public void TwoSum()
        {
            var al = new Algorithms();
            Assert.Equal(new int[] { 0, 1 }, al.TwoSum(new int[] { 2, 7, 11, 15 }, 9));
            Assert.NotEqual(new int[] { 1, 3 }, al.TwoSum(new int[] { 2, 7, 11, 15 }, 18));
        }
    }
}
