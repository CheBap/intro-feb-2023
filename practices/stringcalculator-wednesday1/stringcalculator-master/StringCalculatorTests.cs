
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

    [Fact]
    public void Double()
    {
        var calculator = new StringCalculator();

        var result = calculator.Add("1,2");

        Assert.Equal(3, result);
    }

    [Fact]
    public void ALot()
    {
        var calculator = new StringCalculator();

        var result = calculator.Add("1,2,3,4,5");

        Assert.Equal(15, result);
    }

    [Fact]
    public void Extra()
    {
        var calculator = new StringCalculator();

        var result = calculator.Add("1\n2,3,4");

        Assert.Equal(10, result);
    }

}
