using System;
using System.Collections.Generic;

namespace Project
{
    class OverloadCalculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public int Add(List<int> numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
                sum += num;
            return sum;
        }
    }

    class Methodoverloading
    {
        public static void Run(string[] args)
        {
            OverloadCalculator calc = new OverloadCalculator();

            Console.Write("How many numbers to add? ");
            int count = Convert.ToInt32(Console.ReadLine());

            if (count == 2)
            {
                Console.Write("Enter first number: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second number: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Sum: {calc.Add(a, b)}");
            }
            else if (count == 3)
            {
                Console.Write("Enter first number: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second number: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter third number: ");
                int c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Sum: {calc.Add(a, b, c)}");
            }
            else if (count > 3)
            {
                List<int> numbers = new List<int>();
                for (int i = 0; i < count; i++)
                {
                    Console.Write($"Enter number {i + 1}: ");
                    numbers.Add(Convert.ToInt32(Console.ReadLine()));
                }
                Console.WriteLine($"Sum: {calc.Add(numbers)}");
            }
            else
            {
                Console.WriteLine("Invalid count. Must be 2 or more.");
            }
        }
    }
}