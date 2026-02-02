using System;
using System.Collections.Generic;

namespace Project
{
    class Queuecode
    {
        public static void Run(string[] args)
        {
            Queue<string> queue = new Queue<string>();

            while (true)
            {
                Console.WriteLine("\n1. Enqueue\n2. Dequeue\n3. Peek\n4. Count\n5. Display\n6. Clear\n7. Exit");
                Console.Write("Choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("String: ");
                        string enqueue = Console.ReadLine();
                        queue.Enqueue(enqueue);
                        break;
                    case 2:
                        if (queue.Count > 0)
                            Console.WriteLine($"Dequeued: {queue.Dequeue()}");
                        else
                            Console.WriteLine("Queue is empty");
                        break;
                    case 3:
                        if (queue.Count > 0)
                            Console.WriteLine($"Front: {queue.Peek()}");
                        else
                            Console.WriteLine("Queue is empty");
                        break;
                    case 4:
                        Console.WriteLine($"Count: {queue.Count}");
                        break;
                    case 5:
                        if (queue.Count == 0)
                            Console.WriteLine("Queue is empty");
                        else
                            foreach (string item in queue)
                                Console.WriteLine(item);
                        break;
                    case 6:
                        queue.Clear();
                        Console.WriteLine("Queue cleared");
                        break;
                    case 7:
                        return;
                }
            }
        }
    }
}