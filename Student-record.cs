using System;

public record Student(int RollNumber, string Name, string Course, int Semester);

class Program
{
    static void Main()
    {
        Student student1 = new Student(101, "Jitendra", "MCA", 2);
        Student student2 = new Student(101, "Jitendra", "MCA", 2);

        Console.WriteLine("Student 1: " + student1);
        Console.WriteLine("Student 2: " + student2);
        Console.WriteLine("Are students equal: " + (student1 == student2));
    }
}
