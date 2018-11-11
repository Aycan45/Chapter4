using System;

class Task1
{
    static void Main()
    {
        Console.Write("Enter a:");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter b:");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter c:");
        int c = int.Parse(Console.ReadLine());
        int sum = a + b + c;
        Console.WriteLine($"The sum of the three numbers is {sum}");
    }
}

