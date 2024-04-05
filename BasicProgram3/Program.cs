using System;
namespace BasicProgram3;
class Program
{
    public static void Main(string[] args)
    {
        int celcius=int.Parse(Console.ReadLine());
        double fahrenheit=(celcius*9/5)+32;
        double kelvin=celcius+273.15;
        Console.WriteLine(kelvin);
         Console.WriteLine(fahrenheit);
    }

}
