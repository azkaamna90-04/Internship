using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Ali", Department = "CS" },
            new Student { Id = 2, Name = "Sara", Department = "IT" },
            new Student { Id = 3, Name = "Ahmed", Department = "CS" },
            new Student { Id = 4, Name = "Ayesha", Department = "SE" },
            new Student { Id = 5, Name = "Hassan", Department = "CS" }
        };

        Console.Write("Enter student ID: ");
        int searchId = Convert.ToInt32(Console.ReadLine());

        var studentFound = students.FirstOrDefault(s => s.Id == searchId);

        if (studentFound != null)
        {
            Console.WriteLine("Student Found:");
            Console.WriteLine("Name: " + studentFound.Name);
            Console.WriteLine("Department: " + studentFound.Department);
        }
        else
        {
            Console.WriteLine("Student not found.");
        }
    }
}