namespace Tests;

public class Test2
{
    bool isValid(string sequence)
    {
        return test2.solution(sequence);
    }

    [Theory]
    [InlineData("()")]
    [InlineData("[(){}]")]
    [InlineData("(t[(t{test})t])")]
    [InlineData("(test(valid{until[pro(ved)[w{ron(g)}]]}))")]
    public void Test2_Valid_Sequence(string value)
    {
        Assert.Equal(true, isValid(value));
    }

    [Fact]
    public void Test2_Valid_Sequence_2()
    {
        Assert.True(isValid("(va[l]{[]u}e)"));
    }

    [Theory]
    [InlineData("{[)}")]
    [InlineData("{]")]
    [InlineData("{})")]
    public void Test2_Invalid_Sequence(string value)
    {
        Assert.False(isValid(value));
    }

    [Theory]
    [InlineData("{[)}")]
    [InlineData("{]")]
    [InlineData("{})")]
    public void Test2_Invalid_Sequence_2(string value)
    {
        Assert.False(isValid(value));
    }
}