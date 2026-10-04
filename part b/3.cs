using System;

interface IPrintable
{
    void Print();
}

class Student : IPrintable
{
    public string Name { get; set; }
    public int RollNumber { get; set; }

    public Student(string name, int rollNumber)
    {
        Name = name;
        RollNumber = rollNumber;
    }

    public void Print()
    {
        Console.WriteLine("Student Name: " + Name);
        Console.WriteLine("Roll Number: " + RollNumber);
    }
}

class Program
{
    static void Main()
    {
        Student student1 = new Student("Aliha", 101);

        student1.Print();
    }
}