using System;
using System.Collections.Generic;
using System.Linq;

/*
 LINQ (Language Integrated Query) Demo
 
 Demonstrates:
 - Method Syntax: Where, OrderByDescending, Select
 - Query Syntax: from/where/orderby/select
 - Grouping: GroupBy
 - Joining: Join between two collections
 - Aggregation: Count, Sum, Average, Max, Min, FirstOrDefault
 
 Usage:
 - Call Linq.Run() from Main to execute the demo
 - Or replace existing Main with: static void Main() { Linq.Run(); }
*/

public class Student
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Department { get; set; }
    public int Marks { get; set; }
}

public class Department
{
    public int Id { get; set; }
    public string? DeptName { get; set; }
}

public static class Linq
{
    static List<Student> students = new List<Student>()
    {
        new Student { Id = 1, Name = "Alice", Department = "CSE", Marks = 92 },
        new Student { Id = 2, Name = "Bob", Department = "ECE", Marks = 75 },
        new Student { Id = 3, Name = "Charlie", Department = "CSE", Marks = 88 },
        new Student { Id = 4, Name = "Diana", Department = "MECH", Marks = 95 },
        new Student { Id = 5, Name = "Eve", Department = "ECE", Marks = 65 },
        new Student { Id = 6, Name = "Frank", Department = "CSE", Marks = 78 },
        new Student { Id = 7, Name = "Grace", Department = "MECH", Marks = 82 },
    };

    static List<Department> departments = new List<Department>()
    {
        new Department { Id = 1, DeptName = "CSE" },
        new Department { Id = 2, DeptName = "ECE" },
        new Department { Id = 3, DeptName = "MECH" }
    };

    public static void Run()
    {
        Console.WriteLine("========== LINQ Demo ==========\n");

        // 1. Method Syntax - Where, OrderByDescending, Select
        MethodSyntaxExample();

        // 2. Query Syntax
        QuerySyntaxExample();

        // 3. Grouping
        GroupingExample();

        // 4. Joining
        JoiningExample();

        // 5. Aggregation
        AggregationExample();
    }

    static void MethodSyntaxExample()
    {
        Console.WriteLine("1. METHOD SYNTAX - Filter, Order, Project");
        Console.WriteLine("---");

        Console.Write("Enter cutoff marks: ");
        int cutoff = int.Parse(Console.ReadLine() ?? "70");

        // Method Syntax: Where -> OrderByDescending -> Select
        var result = students
                        .Where(s => s.Marks >= cutoff)
                        .OrderByDescending(s => s.Marks)
                        .Select(s => new { s.Name, s.Department, s.Marks });

        Console.WriteLine($"\nStudents with marks >= {cutoff}:");

        if (result.Any())
        {
            foreach (var s in result)
            {
                Console.WriteLine($"  Name: {s.Name}, Department: {s.Department}, Marks: {s.Marks}");
            }
        }
        else
        {
            Console.WriteLine("  No students found above cutoff marks");
        }

        Console.WriteLine();
    }

    static void QuerySyntaxExample()
    {
        Console.WriteLine("2. QUERY SYNTAX - from/where/orderby/select");
        Console.WriteLine("---");

        // Query Syntax (SQL-like)
        var result = from s in students
                     where s.Marks >= 80
                     orderby s.Name
                     select new { s.Id, s.Name, s.Marks };

        Console.WriteLine("Students with marks >= 80 (sorted by name):");

        foreach (var s in result)
        {
            Console.WriteLine($"  ID: {s.Id}, Name: {s.Name}, Marks: {s.Marks}");
        }

        Console.WriteLine();
    }

    static void GroupingExample()
    {
        Console.WriteLine("3. GROUPING - GroupBy");
        Console.WriteLine("---");

        // Group students by department
        var grouped = students
                        .GroupBy(s => s.Department)
                        .Select(g => new 
                        { 
                            Department = g.Key, 
                            Count = g.Count(), 
                            AvgMarks = g.Average(s => s.Marks),
                            Students = g.Select(s => s.Name).ToList()
                        });

        Console.WriteLine("Students grouped by department:");

        foreach (var dept in grouped)
        {
            Console.WriteLine($"\n  Department: {dept.Department}");
            Console.WriteLine($"    Count: {dept.Count}");
            Console.WriteLine($"    Average Marks: {dept.AvgMarks:F2}");
            Console.WriteLine($"    Students: {string.Join(", ", dept.Students)}");
        }

        Console.WriteLine();
    }

    static void JoiningExample()
    {
        Console.WriteLine("4. JOINING - Inner Join");
        Console.WriteLine("---");

        // Join students with departments
        var joined = students
                        .Join(departments,
                              s => s.Department,
                              d => d.DeptName,
                              (s, d) => new
                              {
                                  StudentName = s.Name,
                                  DepartmentName = d.DeptName,
                                  Marks = s.Marks
                              })
                        .OrderBy(x => x.DepartmentName)
                        .ThenBy(x => x.StudentName);

        Console.WriteLine("Students with Department Info:");

        foreach (var item in joined)
        {
            Console.WriteLine($"  {item.StudentName} | Dept: {item.DepartmentName} | Marks: {item.Marks}");
        }

        Console.WriteLine();
    }

    static void AggregationExample()
    {
        Console.WriteLine("5. AGGREGATION - Count, Sum, Average, Max, Min");
        Console.WriteLine("---");

        Console.WriteLine($"Total Students: {students.Count()}");
        Console.WriteLine($"Total Marks (sum): {students.Sum(s => s.Marks)}");
        Console.WriteLine($"Average Marks: {students.Average(s => s.Marks):F2}");
        Console.WriteLine($"Highest Marks: {students.Max(s => s.Marks)}");
        Console.WriteLine($"Lowest Marks: {students.Min(s => s.Marks)}");

        // FirstOrDefault
        var topStudent = students.OrderByDescending(s => s.Marks).FirstOrDefault();
        Console.WriteLine($"Top Student: {topStudent?.Name} ({topStudent?.Marks})");

        // Distinct departments
        var uniqueDepts = students.Select(s => s.Department).Distinct();
        Console.WriteLine($"Unique Departments: {string.Join(", ", uniqueDepts)}");

        // Skip and Take
        Console.WriteLine("\nFirst 3 students (after sorting by name):");
        var first3 = students.OrderBy(s => s.Name).Take(3);
        foreach (var s in first3)
        {
            Console.WriteLine($"  {s.Name}");
        }

        Console.WriteLine();
    }
}
