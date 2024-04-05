using System;
namespace BasicProgram1;
class Program
{
    public static void Main(string[] args)
    {
        int num1=int.Parse(Console.ReadLine());
        int num2=int.Parse(Console.ReadLine());
        int num3=int.Parse(Console.ReadLine());
        int result=num1*num2*num3;
        Console.WriteLine(result);
    }
}