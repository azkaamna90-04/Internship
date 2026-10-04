using System;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void Introduce()
    {
        Console.WriteLine("My name is " + Name + " and I am " + Age + " years old.");
    }
}

class Program
{
    static void Main()
    {
        Person person1 = new Person();

        person1.Name = "Aliha";
        person1.Age = 21;

        person1.Introduce();
    }
}