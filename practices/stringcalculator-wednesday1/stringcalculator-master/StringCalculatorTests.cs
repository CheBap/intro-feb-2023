
namespace StringCalculator;

public class StringCalculatorTests
{
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new StringCalculator();

        var result = calculator.Add("");

        Assert.Equal(0, result);
    }

    [Fact]
    public void Single()
    {
        var calculator = new StringCalculator();

        var result = calculator.Add("1");

        Assert.Equal(1, result);
    }
}
