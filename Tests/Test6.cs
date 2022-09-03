namespace Tests
{
    public class Test6
    {
        int[] result(int[] a, int k)
        {
            return test6.solution(a, k);
        }

        [Theory]
        [InlineData(new int[] { 3, 8, 9, 7, 6 }, 3)]
        public void Test6_3_swaps(int[] a, int k)
        {
            Assert.Equal(new int[] { 9, 7, 6, 3, 8 }, result(a, k));
        }

        [Theory]
        [InlineData(new int[] { 0, 0, 0 }, 3)]
        public void Test6_1_swaps(int[] a, int k)
        {
            Assert.Equal(new int[] { 0, 0, 0 }, result(a, k));
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4 }, 4)]
        public void Test6_4_swaps(int[] a, int k)
        {
            Assert.Equal(new int[] { 1, 2, 3, 4 }, result(a, k));
        }
    }
}