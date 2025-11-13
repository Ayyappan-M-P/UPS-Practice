// using System;

// class Program1
// {
//     static void Main()
//     {
//         string name;
//         int marks;
//         double total = 0; 

//         Console.WriteLine("Student Grade Evaluation System");

//         for (int i = 1; i <= 5; i++)
//         {
//             Console.Write($"\nEnter name of student {i}: ");
//             name = Console.ReadLine();

//             do
//             {
//                 Console.Write($"Enter total marks (out of 500) for {name}: ");
//                 marks = Convert.ToInt32(Console.ReadLine());

//                 if (marks < 0)
//                 {
//                     Console.WriteLine("Marks cannot be negative. Please re-enter.");
//                 }

//             } while (marks < 0);

            
//             double percent = (marks / 500.0) * 100;
//             total += percent;

//             string grade;

//             if (percent >= 90)
//                 grade = "A+";
//             else if (percent >= 80 && percent <= 89)
//                 grade = "A";
//             else if (percent >= 70 && percent <= 79)
//                 grade = "B";
//             else if (percent >= 60 && percent <= 69)
//                 grade = "C";
//             else
//                 grade = "Fail";

          
//             Console.WriteLine($"Student: {name}");
//             Console.WriteLine($"percentage: {percent:F2}%");
//             Console.WriteLine($"Grade: {grade}");
//         }

//         double avg = total / 5;
//         Console.WriteLine($"\nClass Average percentage: {avg:F2}%");
//     }
// }
