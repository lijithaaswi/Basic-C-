using System;
namespace BasicProgram5;
class Program
{
    public static void Main(string[] args)
    {
        int n=int.Parse(Console.ReadLine());
        int num1=n%10;
        int num2=n/10;
        int sum=num1+num2;
        
        Console.WriteLine(sum);


    }
}