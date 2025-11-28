
// //Answer :
// // 1.Using partial classes helps split a large class into smaller parts, making the code easier to read and manage.
// // 2.Generic lists store and handle many objects of the same type safely and easily.
// // 3.Together they make programs more organized, flexible, and efficient to work.



// public partial class Student
// {
//     public string Name { get; set; }
//     public int RollNo { get; set; }
//     public double Marks { get; set; }

//     public Student(string name, int rollNo, double marks)
//     {
//         Name = name;
//         RollNo = rollNo;
//         Marks = marks;
//     }
// }

// public partial class Student
// {
//     public string GetGrade()
//     {
//         if (Marks >= 90)
//             return "A+";
//         else if (Marks >= 80)
//             return "A";
//         else if (Marks >= 70)
//             return "B";
//         else if (Marks >= 60)
//             return "C";
//         else
//             return "Fail";
//     }
// }


// class Program2
// {
//     static void Main()
//     {
//         List<Student> students = new List<Student>
//         {
//             new Student("Karan", 1, 90),
//             new Student("Mani", 2, 82),
//             new Student("Rahul", 3, 68),
//             new Student("Ayyappan", 4, 95)
//         };

//         Console.WriteLine("Student Report");

//         foreach (Student s in students)
//         {
//             Console.WriteLine($"Name: {s.Name}, Roll No: {s.RollNo}, Marks: {s.Marks}, Grade: {s.GetGrade()}");
//         }
//     }
// }
