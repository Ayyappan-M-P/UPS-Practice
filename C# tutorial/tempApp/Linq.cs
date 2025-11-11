using System;
using System.Collections.Generic;
using System.Linq;

/*
 Complete LINQ Example
 
 Demonstrates:
 - Student class and sample data
 - Method Syntax (filtering, ordering, projection)
 - Query Syntax (alternative syntax)
 - Grouping
 - Joining
 - Aggregation (Count, Sum, Average, etc.)
 - Any() and FirstOrDefault()
 
 Usage: Call Linq.Run() from Main
*/

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public int Marks { get; set; }
}

public class Department
{
    public int DeptId { get; set; }
    public string DeptName { get; set; }
}

public static class Linq
{
    // Sample student data
    static List<Student> students = new List<Student>
    {
        new Student { Id = 1, Name = "Alice", Department = "CS", Marks = 85 },
        new Student { Id = 2, Name = "Bob", Department = "EC", Marks = 75 },
        new Student { Id = 3, Name = "Charlie", Department = "CS", Marks = 92 },
        new Student { Id = 4, Name = "Diana", Department = "ME", Marks = 68 },
        new Student { Id = 5, Name = "Eve", Department = "CS", Marks = 88 },
        new Student { Id = 6, Name = "Frank", Department = "EC", Marks = 78 },
    };

    // Sample department data
    static List<Department> departments = new List<Department>
    {
        new Department { DeptId = 1, DeptName = "Computer Science" },
        new Department { DeptId = 2, DeptName = "Electronics" },
        new Department { DeptId = 3, DeptName = "Mechanical" },
    };

    public static void Run()
    {
        Console.WriteLine("===== LINQ Examples =====\n");

        // Example 1: Method Syntax (from user input)
        MethodSyntaxExample();

        // Example 2: Query Syntax
        QuerySyntaxExample();

        // Example 3: Grouping
        GroupingExample();

        // Example 4: Joining
        JoiningExample();

        // Example 5: Aggregation
        AggregationExample();

        // Example 6: Deferred Execution
        DeferredExecutionExample();
    }

    // Example 1: Method Syntax (filtering, ordering, projection)
    static void MethodSyntaxExample()
    {
        Console.WriteLine("--- Example 1: Method Syntax ---");
        Console.Write("Enter Students Cutoff Marks: ");
        int cutoff = int.Parse(Console.ReadLine() ?? "70");

        // Method Syntax: Where -> OrderByDescending -> Select
        var result = students
            .Where(s => s.Marks >= cutoff)
            .OrderByDescending(s => s.Name)
            .Select(s => new { s.Name, s.Department, s.Marks });

        Console.WriteLine($"Student Details with marks >= {cutoff}");

        if (result.Any())
        {
            foreach (var s in result)
            {
                Console.WriteLine($"Name: {s.Name}, Department: {s.Department}, Marks: {s.Marks}");
            }
        }
        else
        {
            Console.WriteLine("No students found above cutoff marks");
        }
        Console.WriteLine();
    }

    // Example 2: Query Syntax (alternative to method syntax)
    static void QuerySyntaxExample()
    {
        Console.WriteLine("--- Example 2: Query Syntax ---");

        // Query Syntax equivalent to method syntax
        var result = from s in students
                     where s.Marks >= 80
                     orderby s.Name
                     select new { s.Name, s.Marks };

        Console.WriteLine("Students with marks >= 80 (Query Syntax):");
        foreach (var s in result)
        {
            Console.WriteLine($"Name: {s.Name}, Marks: {s.Marks}");
        }
        Console.WriteLine();
    }

    // Example 3: Grouping
    static void GroupingExample()
    {
        Console.WriteLine("--- Example 3: Grouping by Department ---");

        // Group students by department
        var grouped = students
            .GroupBy(s => s.Department)
            .Select(g => new
            {
                Department = g.Key,
                Count = g.Count(),
                AvgMarks = g.Average(s => s.Marks),
                Students = g.ToList()
            });

        foreach (var dept in grouped)
        {
            Console.WriteLine($"Department: {dept.Department}");
            Console.WriteLine($"  Count: {dept.Count}, Average Marks: {dept.AvgMarks:F2}");
            foreach (var s in dept.Students)
            {
                Console.WriteLine($"    - {s.Name} ({s.Marks})");
            }
        }
        Console.WriteLine();
    }

    // Example 4: Joining
    static void JoiningExample()
    {
        Console.WriteLine("--- Example 4: Joining Students with Departments ---");

        // Inner join: students with their full department names
        var joined = from s in students
                     join d in departments on s.Department equals d.DeptName.Substring(0, 2).ToUpper()
                     select new
                     {
                         s.Name,
                         s.Marks,
                         FullDeptName = d.DeptName
                     };

        Console.WriteLine("Students and their Departments:");
        foreach (var item in joined)
        {
            Console.WriteLine($"Name: {item.Name}, Marks: {item.Marks}, Dept: {item.FullDeptName}");
        }
        Console.WriteLine();
    }

    // Example 5: Aggregation
    static void AggregationExample()
    {
        Console.WriteLine("--- Example 5: Aggregation ---");

        int totalStudents = students.Count();
        double avgMarks = students.Average(s => s.Marks);
        int maxMarks = students.Max(s => s.Marks);
        int minMarks = students.Min(s => s.Marks);
        int sumMarks = students.Sum(s => s.Marks);

        Console.WriteLine($"Total Students: {totalStudents}");
        Console.WriteLine($"Average Marks: {avgMarks:F2}");
        Console.WriteLine($"Highest Marks: {maxMarks}");
        Console.WriteLine($"Lowest Marks: {minMarks}");
        Console.WriteLine($"Sum of Marks: {sumMarks}");

        // FirstOrDefault
        var firstStudent = students.FirstOrDefault();
        if (firstStudent != null)
            Console.WriteLine($"First Student: {firstStudent.Name}");

        // Find student with highest marks
        var topStudent = students.OrderByDescending(s => s.Marks).FirstOrDefault();
        Console.WriteLine($"Top Student: {topStudent?.Name} ({topStudent?.Marks})");
        Console.WriteLine();
    }

    // Example 6: Deferred Execution vs Immediate Execution
    static void DeferredExecutionExample()
    {
        Console.WriteLine("--- Example 6: Deferred Execution ---");

        // Deferred: query is not executed until enumerated
        IEnumerable<Student> deferredQuery = students.Where(s => s.Marks > 75);
        Console.WriteLine("Query created (deferred, not executed yet)");

        // Immediate: query executes right away
        List<Student> immediateQuery = students.Where(s => s.Marks > 75).ToList();
        Console.WriteLine("Query executed immediately (converted to List)");

        Console.WriteLine($"\nStudents with marks > 75:");
        foreach (var s in deferredQuery)
        {
            Console.WriteLine($"Name: {s.Name}, Marks: {s.Marks}");
        }
        Console.WriteLine();
    }
}
