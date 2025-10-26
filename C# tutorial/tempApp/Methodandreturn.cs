//  class Methodandreturn
//     {
//     static void Main(string[] args)
//     {
//         // return  = returns data back to the place where a method is invoked
//         double x;
//         double y;
//         double result;

//         Console.WriteLine("Enter in number 1: ");
//         x = Convert.ToDouble(Console.ReadLine());

//         Console.WriteLine("Enter in number 2: ");
//         y = Convert.ToDouble(Console.ReadLine());

//         result = Multiply(x, y);

//         Console.WriteLine(result);

//         double total = CheckOut(3.99, 5.75, 15, 1.00, 10.25);

//         Console.WriteLine(total);

//         Console.ReadKey();
//     }
//     static double Multiply(double x, double y)
//     {
//         return x * y;
//     }
//             //params keyword = a method parameter that takes a variable number of arguments.
//             //                 The parameter type must be a single - dimensional array

//     static double CheckOut(params double[] prices)
//     {
//         double total = 0;

//         foreach (double price in prices)
//         {
//             total += price;
//         }
//         return total;
//     }
// }