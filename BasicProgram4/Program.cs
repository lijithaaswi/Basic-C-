using System;
using System.Diagnostics.Metrics;
namespace BasicProgram4;
class Program
{

    public static void Main(string[] args)
    {
        double n=double.Parse(Console.ReadLine());
        double cm=n*100;
        double mm=cm*10;
        double inch=39.37*n;
        double feet=3.28084*n;
        double mile=0.000621371192*n;

        Console.WriteLine("Centimeter : "+cm);
         Console.WriteLine("Millimeters : "+mm);
          Console.WriteLine("Inches : "+inch);
           Console.WriteLine("Feet : "+feet);
            Console.WriteLine("Miles : "+mile);
    }
}
