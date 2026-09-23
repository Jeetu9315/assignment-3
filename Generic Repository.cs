using System;
using System.Collections.Generic;

class Student
{
    public int RollNumber { get; set; }
    public string Name { get; set; }
}

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class Repository<T>
{
    private List<T> items = new List<T>();

    public void Add(T item)
    {
        items.Add(item);
    }

    public T Get(int index)
    {
        return items[index];
    }

    public int Count()
    {
        return items.Count;
    }
}

class Program
{
    static void Main()
    {
        Repository<Student> studentRepository = new Repository<Student>();

        studentRepository.Add(new Student
        {
            RollNumber = 101,
            Name = "Jitendra"
        });

        Student student = studentRepository.Get(0);

        Console.WriteLine("Student Roll Number: " + student.RollNumber);
        Console.WriteLine("Student Name: " + student.Name);

        Repository<Employee> employeeRepository = new Repository<Employee>();

        employeeRepository.Add(new Employee
        {
            Id = 501,
            Name = "Rahul"
        });

        Employee employee = employeeRepository.Get(0);

        Console.WriteLine("Employee ID: " + employee.Id);
        Console.WriteLine("Employee Name: " + employee.Name);
    }
}
