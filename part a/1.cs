using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double sum = num1 + num2;
        double difference = num1 - num2;
        double product = num1 * num2;

        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Difference: " + difference);
        Console.WriteLine("Product: " + product);

        if (num2 != 0)
        {
            double quotient = num1 / num2;
            Console.WriteLine("Quotient: " + quotient);
        }
        else
        {
            Console.WriteLine("Quotient cannot be calculated because division by zero is not allowed.");
        }
    }
}