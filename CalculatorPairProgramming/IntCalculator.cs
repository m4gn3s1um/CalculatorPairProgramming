namespace CalculatorPairProgramming;

interface IntCalculator
{
    int Result { get; set; }
    int Memory { get; set; }
    void Reset();
    void Add(int x);
    void Subtract(int x);
    void Multiply(int x);
    void Divide(int x);
    void Modulus(int x);

    void ResetMemory();
    void AddMemory();
    void SubtractMemory();
    int GetMemory();


}