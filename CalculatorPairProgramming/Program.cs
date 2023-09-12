// See https://aka.ms/new-console-template for more information

using CalculatorPairProgramming;

Calculator cc = new Calculator();

cc.Result = 100;
cc.Memory = 50;

cc.Reset();
Console.WriteLine(cc.Result);
Console.WriteLine(cc.Memory);