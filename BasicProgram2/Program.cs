using System;
namespace BasicProgram2;
class Program{
    public static void Main(string[] args)
    {
        decimal num1=decimal.Parse(Console.ReadLine());
        decimal num2=decimal.Parse(Console.ReadLine());
        Console.WriteLine(num1+num2);
        Console.WriteLine(num1-num2);
        Console.WriteLine(num1*num2);
        Console.WriteLine(num1/num2);
        Console.WriteLine(num1%num2);
    }
}