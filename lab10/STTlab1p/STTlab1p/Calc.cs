
using System;
public class Calc
{
    public void calculate()
    {
        Console.Write("Enter first number: ");
        int a = Int32.Parse(Console.ReadLine());
        Console.Write("\nEnter Second number: ");
        int b = Int32.Parse(Console.ReadLine());
        int sum = a + b;
        Console.WriteLine(sum);
        if ((sum % 2) == 0)
        {
            Console.WriteLine("sum is even");
        }
        else
        {
            Console.WriteLine("Sum is odd");
        }
        int subtraction = a - b;
        Console.WriteLine("Subtraction: " + subtraction);
        int multiplication = b * a;
        Console.WriteLine("Multiplication: " + multiplication);
        
        try
        {
            int division = a / b;
            Console.WriteLine("Division: " + division);
        }
        catch
        {
            Console.WriteLine("Can't divide by zero");
        }
        
    }
}