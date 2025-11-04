// using System;
// using System.Collections;

// // Non-generic collections demo
// // Contains a static Run() method showing ArrayList, Hashtable, Queue, Stack and SortedList
// // Usage:
// //  - Call NonGenericCollections.Run() from your project's Main method.
// //  - Or temporarily create a Main that calls Run() to execute this demo.

// class NonGenericCollections
// {
//     public static void Run()
//     {
//         Console.WriteLine("Non-Generic Collections demo\n");

//         // ArrayList: can hold mixed types (no compile-time type safety)
//         ArrayList arrayList = new ArrayList();
//         arrayList.Add(1);
//         arrayList.Add("two");
//         arrayList.Add(3.0);

//         Console.WriteLine("ArrayList contents:");
//         foreach (var item in arrayList)
//         {
//             Console.WriteLine($" - {item} (Type: {item.GetType().Name})");
//         }

//         // Hashtable: key/value pairs (non-generic)
//         Hashtable table = new Hashtable();
//         table["one"] = 1;
//         table["two"] = "second";

//         Console.WriteLine("\nHashtable contents:");
//         foreach (DictionaryEntry entry in table)
//         {
//             Console.WriteLine($" - {entry.Key}: {entry.Value} (Type: {entry.Value.GetType().Name})");
//         }

//         // Queue: FIFO
//         Queue queue = new Queue();
//         queue.Enqueue(1);
//         queue.Enqueue(2);
//         queue.Enqueue(3);

//         Console.WriteLine("\nQueue (dequeue):");
//         while (queue.Count > 0)
//         {
//             Console.WriteLine($" - {queue.Dequeue()}");
//         }

//         // Stack: LIFO
//         Stack stack = new Stack();
//         stack.Push(1);
//         stack.Push(2);
//         stack.Push(3);

//         Console.WriteLine("\nStack (pop):");
//         while (stack.Count > 0)
//         {
//             Console.WriteLine($" - {stack.Pop()}");
//         }

//         // SortedList: key/value pairs sorted by key
//         SortedList sorted = new SortedList();
//         sorted.Add(3, "three");
//         sorted.Add(1, "one");
//         sorted.Add(2, "two");

//         Console.WriteLine("\nSortedList (by key):");
//         foreach (DictionaryEntry entry in sorted)
//         {
//             Console.WriteLine($" - {entry.Key}: {entry.Value}");
//         }

//         Console.WriteLine("\nNote: Non-generic collections allow heterogeneous objects but lack compile-time type safety. Prefer generic collections (List<T>, Dictionary<K,V>, etc.) for type safety and performance when possible.");
//     }
// }
