using Xunit;
using CalcApp;
namespace CalcTest;


public class CalculatorTests
{
    private readonly Calc calc = new Calc();
    [Fact]
    public void Add_ReturnsCorrectResult()
    {
        Assert.Equal(5, calc.Add(2, 3));
    }
    [Fact]
    public void Multiply_ReturnsCorrectResult()
    {
        Assert.Equal(20, calc.Multiply(4, 5));
    }
}