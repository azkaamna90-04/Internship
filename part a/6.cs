using System;

class Program
{
    static void Main()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n--- MAIN MENU ---");
            Console.WriteLine("1. Add Two Numbers");
            Console.WriteLine("2. Check Even or Odd");
            Console.WriteLine("3. Show Hello Message");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddNumbers();
                    break;

                case 2:
                    CheckEvenOdd();
                    break;

                case 3:
                    Console.WriteLine("Hello! Welcome to the C# program.");
                    break;

                case 4:
                    Console.WriteLine("Exiting program...");
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void AddNumbers()
    {
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Sum = " + (num1 + num2));
    }

    static void CheckEvenOdd()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("Even Number");
        }
        else
        {
            Console.WriteLine("Odd Number");
        }
    }
}