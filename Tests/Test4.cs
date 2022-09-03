namespace Tests
{
    public class Test4
    {
        int Score(string[] ops)
        {
            return test4.solution(ops);
        }
        [Theory]
        [InlineData(new object[] { "5", "2", "C", "D", "+" })]
        public void Test4_equals_30(params string[] ops)
        {
            Assert.Equal(30, Score(ops));
        }

        [Theory]
        [InlineData(new object[] { "5", "-2", "4", "C", "D", "9", "+", "+" })]
        public void Test4_equals_27(params string[] ops)
        {
            Assert.Equal(27, Score(ops));
        }

        [Theory]
        [InlineData(new object[] { "1" })]
        public void Test4_equals_1(params string[] ops)
        {
            Assert.Equal(1, Score(ops));
        }
    }
}