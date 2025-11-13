using System;

// Define a delegate for mathematical operations
public delegate void CalculatorDelegate(int a, int b);

public class CalculatorClass
{
    public static void Add(int a, int b)
    {
        Console.WriteLine($"The addition value is: {a + b}");
    }

    public static void Subtract(int a, int b)
    {
        Console.WriteLine($"The subtraction value is: {a - b}");
    }

    public static void Multiply(int a, int b)
    {
        Console.WriteLine($"The multiplication value is: {a * b}");
    }
}

public class Deligate
{
    static void Main(string[] args)
    {
        // Initialize a delegate chain with the Add method
        CalculatorDelegate calculator = new CalculatorDelegate(CalculatorClass.Add);

        // Add Subtract method to the delegate chain
        calculator += CalculatorClass.Subtract;

        // Add Multiply method to the delegate chain
        calculator += CalculatorClass.Multiply;

        // Add an anonymous method for division to the delegate chain
        calculator += delegate (int x, int y)
        {
            if (y != 0)
            {
                Console.WriteLine($"The division value is: {(double)x / y}");
            }
            else
            {
                Console.WriteLine("Division by zero is not allowed");
            }
        };

        // Invoke all methods in the delegate chain with the arguments (45, 5)
        calculator(45, 5);

        Console.ReadKey(); 
    }
}