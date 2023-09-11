using CalculatorPairProgramming;

namespace CalculatorTest;

public class Tests
{

    private Calculator _calculator;
    
    
    [SetUp]
    public void Setup()
    {
        _calculator = new Calculator();
        _calculator.Result = 42;
    }

    [Test]
    public void Reset()
    {
        Assert.That(_calculator.Result == 0);
    }

    [Test]
    public void AddTest()
    {
        var number = 2147483644;
        //_calculator.Add(number);
        
        //Assert.That(_calculator.Result.Equals(54));
        Assert.Throws<OverflowException>(() => _calculator.Add(number));
    }

    [Test]
    public void SubtractTest()
    {
        var number = -10;
        _calculator.Subtract(number);
        
        Assert.That(_calculator.Result.Equals(52));
    }

    [Test]
    public void MultiplyTest()
    {
        var number = 2000000000;

        Assert.Throws<OverflowException>(() => _calculator.Multiply(number));
    }

    [Test]
    public void DivideTest()
    {
        int number = 0;

        Assert.Throws<Exception>(() => _calculator.Divide(number));
    }

    [Test]
    public void ModulusTest()
    {
        var number = 5;
        _calculator.Modulus(number);
        
        Assert.That(_calculator.Result.Equals(2));
    }
}