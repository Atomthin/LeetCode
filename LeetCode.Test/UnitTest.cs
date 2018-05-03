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

        [Fact]
        public void IsToeplitzMatrix()
        {
            Assert.True(al.IsToeplitzMatrix(new int[,] { { 1, 2, 3, 4 }, { 5, 1, 2, 3 }, { 9, 5, 1, 2 } }));
            Assert.False(al.IsToeplitzMatrix(new int[,] { { 1, 2 }, { 2, 2 } }));
        }

        [Fact]
        public void CountPrimeSetBits()
        {
            Assert.Equal(4, al.CountPrimeSetBits(6, 10));
            Assert.Equal(23, al.CountPrimeSetBits(842,888));
            Assert.Equal(21, al.CountPrimeSetBits(567, 607));
        }
    }
}
