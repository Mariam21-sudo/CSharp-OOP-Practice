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

    public void DisplayInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }
}

class Student : Person
{
    public int StudentId { get; set; }

    public Student(string name, int age, int studentId)
        : base(name, age)
    {
        StudentId = studentId;
    }

    public void Study()
    {
        Console.WriteLine(Name + " is studying");
    }
}

class Instructor : Person
{
    public string Subject { get; set; }

    public Instructor(string name, int age, string subject)
        : base(name, age)
    {
        Subject = subject;
    }

    public void Teach()
    {
        Console.WriteLine(Name + " is teaching " + Subject);
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student("Ahmed", 20, 101);
        Instructor instructor = new Instructor("Mona", 35, "C#");

        Console.WriteLine("Student Information:");
        student.DisplayInfo();
        Console.WriteLine("Student ID: " + student.StudentId);
        student.Study();

        Console.WriteLine();

        Console.WriteLine("Instructor Information:");
        instructor.DisplayInfo();
        Console.WriteLine("Subject: " + instructor.Subject);
        instructor.Teach();
    }
}
