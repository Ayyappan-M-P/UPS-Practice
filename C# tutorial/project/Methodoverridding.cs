using System;

namespace Project
{
    class OverrideCalculator
    {
        public virtual double Calculate(double a, double b)
        {
            return 0;
        }
    }

    class OverrideAdd : OverrideCalculator
    {
        public override double Calculate(double a, double b)
        {
            return a + b;
        }
    }

    class OverrideSubtract : OverrideCalculator
    {
        public override double Calculate(double a, double b)
        {
            return a - b;
        }
    }

    class OverrideMultiply : OverrideCalculator
    {
        public override double Calculate(double a, double b)
        {
            return a * b;
        }
    }

    class OverrideDivide : OverrideCalculator
    {
        public override double Calculate(double a, double b)
        {
            if (b != 0)
                return a / b;
            else
                throw new DivideByZeroException();
        }
    }

    class Methodoverridding
    {
        public static void Run(string[] args)
        {
            Console.Write("Enter first number: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Operation (+, -, *, /): ");
            char op = Console.ReadLine()[0];

            OverrideCalculator calc = null;

            switch (op)
            {
                case '+':
                    calc = new OverrideAdd();
                    break;
                case '-':
                    calc = new OverrideSubtract();
                    break;
                case '*':
                    calc = new OverrideMultiply();
                    break;
                case '/':
                    calc = new OverrideDivide();
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    return;
            }

            try
            {
                double result = calc.Calculate(a, b);
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
        }
    }
}