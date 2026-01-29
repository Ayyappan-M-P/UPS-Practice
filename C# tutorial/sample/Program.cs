using System;
using System.Linq;
using Models; // Namespace where EF Core scaffolded files are generated

class Program
{
    static void Main()
    {
        // Make sure your PostgreSQL server is running
        using var context = new CollegeContext();

        var students = context.Students.ToList();

        foreach (var student in students)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Email: {student.Email}");
        }
    }
}
