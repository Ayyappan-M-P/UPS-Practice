using System;
using System.Linq;
using SampleEF.Models; 
using Microsoft.EntityFrameworkCore;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Fetching all students from database...");

        
        using (var context = new TestContext())
        {
            var students = context.Students.ToList();

            if (students.Count == 0)
            {
                Console.WriteLine("No students found in the database.");
            }
            else
            {
                foreach (var student in students)
                {
                    Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Email: {student.Email}");
                }
            }
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
