using LeetCode.Core.Problems;
using Xunit;

namespace LeetCode.Test
{
    public class UnitTest
    {
        Algorithms al = new Algorithms();
        [Fact]
        public void TwoSum()
        {

            Assert.Equal(new int[] { 0, 1 }, al.TwoSum(new int[] { 2, 7, 11, 15 }, 9));
            Assert.NotEqual(new int[] { 1, 3 }, al.TwoSum(new int[] { 2, 7, 11, 15 }, 18));
        }

        [Fact]
        public void ShortestToChar()
        {
            Assert.Equal(new int[] { 3, 2, 1, 0, 1, 0, 0, 1, 2, 2, 1, 0 }, al.ShortestToChar("loveleetcode", 'e'));
            Assert.Equal(new int[] { 2, 1, 0, 0, 1 }, al.ShortestToChar("skeet", 'e'));
        }
    }
}
