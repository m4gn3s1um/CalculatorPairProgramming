namespace CalculatorPairProgramming;

public class Calculator : IntCalculator
{
    public int Result { get; set; }
    
    public int Memory { get; set; }
    
    
    
    public void Reset()
    {
        Memory = Result;
        Result = 0;
        
    }

    public void Add(int x)
    {
        
        if (x > Int32.MaxValue - Result || x < Int32.MinValue + Result )
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
        if (x > Int32.MaxValue - Result || x < Int32.MinValue + Result )
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
        if (x > Int32.MaxValue / Result || x < Int32.MinValue * Result )
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

    public void ResetMemory()
    {
        Memory = 0;
    }

    public void AddMemory()
    {
        Memory = Memory + Result;
    }

    public void SubtractMemory()
    {
        Memory = Memory - Result;
    }

    public int GetMemory()
    {
        return Memory;
    }
}