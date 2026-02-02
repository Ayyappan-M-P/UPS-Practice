using System;
using System.Collections.Generic;

namespace Project
{
    class Hashset
    {
        public static void Run(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

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
                        set.Add(add);
                        break;
                    case 2:
                        Console.Write("String: ");
                        string remove = Console.ReadLine();
                        set.Remove(remove);
                        break;
                    case 3:
                        foreach (string item in set)
                            Console.WriteLine(item);
                        break;
                    case 4:
                        return;
                }
            }
        }
    }
}