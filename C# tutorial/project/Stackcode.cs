using System;
using System.Collections.Generic;

namespace Project
{
    class Stackcode
    {
        public static void Run(string[] args)
        {
            Stack<string> stack = new Stack<string>();

            while (true)
            {
                Console.WriteLine("\n1. Push\n2. Pop\n3. Peek\n4. Count\n5. Display\n6. Clear\n7. Exit");
                Console.Write("Choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("String: ");
                        string push = Console.ReadLine();
                        stack.Push(push);
                        break;
                    case 2:
                        if (stack.Count > 0)
                            Console.WriteLine($"Popped: {stack.Pop()}");
                        else
                            Console.WriteLine("Stack is empty");
                        break;
                    case 3:
                        if (stack.Count > 0)
                            Console.WriteLine($"Top: {stack.Peek()}");
                        else
                            Console.WriteLine("Stack is empty");
                        break;
                    case 4:
                        Console.WriteLine($"Count: {stack.Count}");
                        break;
                    case 5:
                        if (stack.Count == 0)
                            Console.WriteLine("Stack is empty");
                        else
                            foreach (string item in stack)
                                Console.WriteLine(item);
                        break;
                    case 6:
                        stack.Clear();
                        Console.WriteLine("Stack cleared");
                        break;
                    case 7:
                        return;
                }
            }
        }
    }
}