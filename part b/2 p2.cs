using System;

class Person
{
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }

    public virtual void Work()
    {
        Console.WriteLine(Name + " is doing some work.");
    }
}

class Student : Person
{
    public Student(string name) : base(name)
    {
    }

    public override void Work()
    {
        Console.WriteLine(Name + " is studying.");
    }
}

class Teacher : Person
{
    public Teacher(string name) : base(name)
    {
    }

    public override void Work()
    {
        Console.WriteLine(Name + " is teaching.");
    }
}

class Program
{
    static void Main()
    {
        Person person1 = new Student("Aliha");
        Person person2 = new Teacher("Ahmed");

        person1.Work();
        person2.Work();
    }
}