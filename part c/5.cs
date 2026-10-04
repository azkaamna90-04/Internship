using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter a number: ");

            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You entered: " + number);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input! Please enter a valid number.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("The number is too large or too small.");
        }
    }
}