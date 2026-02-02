using System;
using System.Collections;

namespace Project
{
    class Nongeneric
    {
        public static void Run(string[] args)
        {
            Console.WriteLine("Non-Generic Collections demo\n");

            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("two");
            arrayList.Add(3.0);

            Console.WriteLine("ArrayList contents:");
            foreach (var item in arrayList)
            {
                Console.WriteLine($" - {item} ");
            }

            Hashtable table = new Hashtable();
            table["one"] = 1;
            table["two"] = "second";

            Console.WriteLine("\nHashtable contents:");
            foreach (DictionaryEntry entry in table)
            {
                Console.WriteLine($" - {entry.Key}: {entry.Value}");
            }

            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine("\nQueue (dequeue):");
            while (queue.Count > 0)
            {
                Console.WriteLine($" - {queue.Dequeue()}");
            }

            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push("top");


            Console.WriteLine("\nStack (pop):");
            while (stack.Count > 0)
            {
                Console.WriteLine($" - {stack.Pop()}");
            }

            SortedList sorted = new SortedList();
            sorted.Add(3, "three");
            sorted.Add(1, "one");
            sorted.Add(2, "two");

            Console.WriteLine("\nSortedList (by key):");
            foreach (DictionaryEntry entry in sorted)
            {
                Console.WriteLine($" - {entry.Key}: {entry.Value}");
            }

            
        }
    }
}