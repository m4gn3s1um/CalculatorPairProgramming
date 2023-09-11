namespace CalculatorPairProgramming;

public class Calculator : IntCalculator
{
    public int Result { get; set; }
    
    public void Reset()
    {
        Result = 0;
    }

    public void Add(int x)
    {
        
        if (x > 2147483647 - Result || x < -2147483648 + Result )
        {
            throw new OverflowException("Number was too big");
        }
        else
        {
            Result = Result + x;    
        }
    }

    public void Subtract(int x)
    {
        if (x > 2147483647 - Result || x < -2147483648 + Result )
        {
            throw new OverflowException("Number was too big");
        }
        else
        {
            Result = Result - x;    
        }
    }

    public void Multiply(int x)
    {
        if (x > 2147483647 / Result || x < -2147483648 * Result )
        {
            throw new OverflowException("Number was too big");
        }
        else
        {
            Result = Result * x;    
        }
    }

    public void Divide(int x)
    {
        if (x == 0)
            throw new Exception("Cant divide by 0");
        if(x != 0)
        {
            Result = Result / x;
        }
    }

    public void Modulus(int x)
    {
        Result = Result % x;
    }
}