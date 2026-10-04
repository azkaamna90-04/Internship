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
            new Student { Id = 1, Name = "Aliha", Department = "CS" },
            new Student { Id = 2, Name = "Zainab", Department = "IT" },
            new Student { Id = 3, Name = "Azka", Department = "CS" },
            new Student { Id = 4, Name = "Ayesha", Department = "SE" },
            new Student { Id = 5, Name = "Hajra", Department = "CS" }
        };

        var csStudents = students.Where(s => s.Department == "CS");

        Console.WriteLine("Students from CS Department:");

        foreach (var student in csStudents)
        {
            Console.WriteLine(student.Name);
        }
    }
}