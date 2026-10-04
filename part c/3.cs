using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Marks { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Ali", Marks = 75 },
            new Student { Id = 2, Name = "Sara", Marks = 90 },
            new Student { Id = 3, Name = "Ahmed", Marks = 65 },
            new Student { Id = 4, Name = "Ayesha", Marks = 85 },
            new Student { Id = 5, Name = "Hassan", Marks = 70 }
        };

        var sortedStudents = students.OrderByDescending(s => s.Marks);

        Console.WriteLine("Students sorted by marks:");

        foreach (var student in sortedStudents)
        {
            Console.WriteLine(student.Name + " - " + student.Marks);
        }
    }
}