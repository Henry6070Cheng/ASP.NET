namespace codelist0801;

public class MathHelper
{
    public int Add(int a, int b)
    {
        return a + b;
    }
}

public class MathHelperTests
{
    [Fact]
    public void Add_ShouldReturnSum()
    {
        // Arrange
        var mathHelper = new MathHelper();

        // Act
        int result = mathHelper.Add(2, 3);

        // Assert
        Assert.Equal(5, result);
    }
}