using System;

class Task2
{
    static void Main()
    {
        Console.Write("Enter radius:");
        double r = double.Parse(Console.ReadLine());
        double perimeter = Math.PI * r;
        Console.WriteLine($"The perimeter of the circle is {perimeter}");
        double S = Math.PI * (r*r);
        Console.WriteLine($"S of the circle is {S}");
    }
}

