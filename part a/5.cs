using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 12, 45, 7, 89, 23, 56, 3, 91, 34, 18 };

        int largest = numbers[0];
        int smallest = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > largest)
            {
                largest = numbers[i];
            }

            if (numbers[i] < smallest)
            {
                smallest = numbers[i];
            }
        }

        Console.WriteLine("Largest number: " + largest);
        Console.WriteLine("Smallest number: " + smallest);
    }
}