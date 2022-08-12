using System;
using MyCalc;

namespace HelloApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Calc cal = new Calc();
            Console.WriteLine($"sum = {cal.Add(5,5)}");
            Console.WriteLine($"Multiply = {cal.Multiply(5, 5)}");
            Console.WriteLine($"Substract = {cal.Substract(10,5)}");
            Console.ReadLine();
        }
    }
}
