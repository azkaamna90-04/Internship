using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your marks: ");
        double marks = Convert.ToDouble(Console.ReadLine());

        string grade = GetGrade(marks);

        Console.WriteLine("Your grade is: " + grade);
    }

    static string GetGrade(double marks)
    {
        if (marks >= 90 && marks <= 100)
        {
            return "A";
        }
        else if (marks >= 80)
        {
            return "B";
        }
        else if (marks >= 70)
        {
            return "C";
        }
        else if (marks >= 60)
        {
            return "D";
        }
        else if (marks >= 0)
        {
            return "F";
        }
        else
        {
            return "Invalid Marks";
        }
    }
}