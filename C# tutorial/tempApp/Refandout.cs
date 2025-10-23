// using System;

// class Program
// {
//     static void ProcessNumbers(ref int refNum, out int outNum)
//     {
//         refNum += 10;   // Can read and modify
//         outNum = 50;    // Must assign
//         outNum *= 2;
//     }

//     static void Main()
//     {
//         int myRef = 5;
//         int myOut = 10;

//         ProcessNumbers(ref myRef, out myOut);

//         Console.WriteLine("refNum: " + myRef); // 15
//         Console.WriteLine("outNum: " + myOut); // 50
//     }
// }
