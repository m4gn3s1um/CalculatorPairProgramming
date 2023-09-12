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
        _calculator.Memory = 10;
    }

    [Test]
    public void Reset()
    {
        _calculator.Reset();
        
        Assert.That(_calculator.Memory.Equals(42));
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

    [Test]
    public void CanResetMemory()
    {
        _calculator.ResetMemory();
        Assert.That(_calculator.Memory == 0);
    }

    [Test]
    public void CanAddMemory()
    {
        _calculator.AddMemory();
        Assert.That(_calculator.Memory.Equals(52));
    }

    [Test]
    public void CanSubtractMemory()
    {
        _calculator.SubtractMemory();
        Assert.That(_calculator.Memory.Equals(-32));
    }

    [Test]

    public void CanGetMemory()
    {
        Assert.That(_calculator.GetMemory().Equals(10));
    }
    
    
}