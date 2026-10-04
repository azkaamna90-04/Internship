using System;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Introduce()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }
}

class Student : Person
{
    public string Department { get; set; }

    public Student(string name, int age, string department)
        : base(name, age)
    {
        Department = department;
    }

    public void Study()
    {
        Console.WriteLine(Name + " is studying " + Department);
    }
}

class Teacher : Person
{
    public string Subject { get; set; }

    public Teacher(string name, int age, string subject)
        : base(name, age)
    {
        Subject = subject;
    }

    public void Teach()
    {
        Console.WriteLine(Name + " teaches " + Subject);
    }
}

class Program
{
    static void Main()
    {
        Student student1 = new Student(
            "Aliha",
            21,
            "Artificial Intelligence"
        );

        Teacher teacher1 = new Teacher(
            "Ahmed",
            35,
            "Programming"
        );

        Console.WriteLine("--- Student ---");
        student1.Introduce();
        student1.Study();

        Console.WriteLine("\n--- Teacher ---");
        teacher1.Introduce();
        teacher1.Teach();
    }
}