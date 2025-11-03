// // class Program 
// //     {
// //     static void Main(string[] args)
// //     {

// //         String[,] parkingLot = {{ "Mustang", "F-150", "Explorer" }, 
// //                                 { "Corvette", "Camaro", "Silverado" }, 
// //                                 { "Corolla", "Camry", "Rav4" } 
// //                             };

// //         parkingLot[0, 2] = "Fusion";
// //         parkingLot[2, 0] = "Tacoma";
// //             /*
// //             foreach(String car in parkingLot)
// //             {
// //                 Console.WriteLine(car);
// //             }
// //             */
// //         for(int i = 0; i < parkingLot.GetLength(0); i++)
// //         {
// //             for (int j = 0; j < parkingLot.GetLength(1); j++)
// //             {
// //                 Console.Write(parkingLot[i, j] + " ");
// //             }
// //             Console.WriteLine();
// //         }

// //         Console.ReadKey();
// //     }
// // }

// class Multidimension
// {
//     static void Main()
//     {
//         int[] numbers = { 1, 2, 3, 4, 5 };
//         Console.WriteLine("Single Array elements:");
//         foreach (var number in numbers)
//         {
//             Console.WriteLine(number);
//         }

//         int[,] grid = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
//         Console.WriteLine("Multidimensional Array elements:");
//         for (int i = 0; i < grid.GetLength(0); i++)
//         {
//             for (int j = 0; j < grid.GetLength(1); j++)
//             {
//                 Console.Write(grid[i, j] + " ");
//             }
//             Console.WriteLine();
//         }



//         int[][] matrix = new int[][] { new int[] {1, 2, 3}, new int[] {4, 5, 6}, new int[] {7, 8, 9} };
//         Console.WriteLine("Jagged Array elements:");

//         for (int i = 0; i < matrix.Length; i++)
//         {
//             for (int j = 0; j < matrix[i].Length; j++)
//             {
//                 Console.Write(matrix[i][j] + " ");
//             }
//             Console.WriteLine();
//         }
        


//     }
// }