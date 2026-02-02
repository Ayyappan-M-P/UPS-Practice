using System;
using System.Collections.Generic;

namespace Project
{
    class Dictionarycode
    {
        public static void Run(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();

            Console.Write("Enter the number of students: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter roll number: ");
                int rollNo = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter name: ");
                string name = Console.ReadLine();
                students[rollNo] = name;
            }

            Console.WriteLine("\nStudent Details:");
            foreach (var student in students)
            {
                Console.WriteLine($"Roll No: {student.Key}, Name: {student.Value}");
            }
        }
    }
}