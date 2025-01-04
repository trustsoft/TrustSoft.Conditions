namespace UsageSample.ConsoleApp;

using System;

using Trustsoft.Conditions;

static class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var number = 12;
        Console.WriteLine($"Number is {number}");
        
        Requires.That(number, "number").IsGreaterThan(50);
        
        Console.ReadLine();
    }
}