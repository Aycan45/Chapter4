using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = Int32.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int b = Int32.Parse(Console.ReadLine());

        Console.WriteLine("{0} >= {1}", Math.Max(a, b), Math.Min(a, b))
    }
}

