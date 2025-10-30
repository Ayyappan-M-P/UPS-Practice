// using System;
// using System.Collections.Generic;

// class Dictionary
// {
//     static void Main()
//     {
//         // Create a dictionary with <string, int>
//         Dictionary<string, int> studentMarks = new Dictionary<string, int>();

//         // Adding key-value pairs
//         studentMarks.Add("Ayyappan", 95);
//         studentMarks.Add("Kumar", 88);
//         studentMarks.Add("Rahul", 76);

//         // Accessing value using key
//         Console.WriteLine("Ayyappan's Marks: " + studentMarks["Ayyappan"]);

//         // Updating value
//         studentMarks["Kumar"] = 90;

//         // Checking if a key exists
//         if (studentMarks.ContainsKey("Rahul"))
//         {
//             Console.WriteLine("Rahul is in the list with marks: " + studentMarks["Rahul"]);
//         }

//         // Iterating through dictionary
//         Console.WriteLine("\nAll Students and Marks:");
//         foreach (KeyValuePair<string, int> kvp in studentMarks)
//         {
//             Console.WriteLine($"Name: {kvp.Key}, Marks: {kvp.Value}");
//         }

//         // Removing a key
//         studentMarks.Remove("Rahul");
//     }
// }
