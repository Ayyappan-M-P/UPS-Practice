using System;
using System.Collections.Generic;

namespace Project
{
    class Listcode
    {
        public static void Run(string[] args)
        {
            List<string> list = new List<string>();

            while (true)
            {
                Console.WriteLine("\n1. Add\n2. Remove\n3. Display\n4. Exit");
                Console.Write("Choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("String: ");
                        string add = Console.ReadLine();
                        list.Add(add);
                        break;
                    case 2:
                        Console.Write("Index: ");
                        int index = Convert.ToInt32(Console.ReadLine());
                        if (index >= 0 && index < list.Count)
                            list.RemoveAt(index);
                        break;
                    case 3:
                        for (int i = 0; i < list.Count; i++)
                            Console.WriteLine($"{i}: {list[i]}");
                        break;
                    case 4:
                        return;
                }
            }
        }
    }
}