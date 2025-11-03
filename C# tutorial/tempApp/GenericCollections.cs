// using System;
// using System.Collections.Generic;

// // Generic collections demo
// // Contains a static Run() method showing List<T>, Dictionary<K,V>, Queue<T>, Stack<T>, SortedList<K,V>, HashSet<T>
// // Usage:
// //  - Call GenericCollections.Run() from your project's Main method.
// //  - Or temporarily create a Main that calls Run() to execute this demo.

// class GenericCollections
// {
//     public static void Run()
//     {
//         Console.WriteLine("Generic Collections demo\n");

//         // List<T>
//         List<int> list = new List<int>();
//         for (int i = 0; i < 5; i++) list.Add(i * 10);
//         Console.WriteLine("List<int> contents:");
//         foreach (var v in list) Console.WriteLine($" - {v}");

//         // Dictionary<TKey, TValue>
//         Dictionary<string, int> dict = new Dictionary<string, int>();
//         dict["one"] = 1;
//         dict.Add("two", 2);
//         Console.WriteLine("\nDictionary<string,int> contents:");
//         if (dict.TryGetValue("two", out int twoVal)) Console.WriteLine($" - key=two value={twoVal}");
//         foreach (var kv in dict) Console.WriteLine($" - {kv.Key}: {kv.Value}");

//         // Queue<T> (FIFO)
//         Queue<string> queue = new Queue<string>();
//         queue.Enqueue("first");
//         queue.Enqueue("second");
//         queue.Enqueue("third");
//         Console.WriteLine("\nQueue<string> (dequeue):");
//         while (queue.Count > 0) Console.WriteLine($" - {queue.Dequeue()}");

//         // Stack<T> (LIFO)
//         Stack<string> stack = new Stack<string>();
//         stack.Push("bottom");
//         stack.Push("middle");
//         stack.Push("top");
//         Console.WriteLine("\nStack<string> (pop):");
//         while (stack.Count > 0) Console.WriteLine($" - {stack.Pop()}");

//         // SortedList<TKey, TValue> (sorted by key)
//         SortedList<int, string> sorted = new SortedList<int, string>();
//         sorted.Add(3, "three");
//         sorted.Add(1, "one");
//         sorted.Add(2, "two");
//         Console.WriteLine("\nSortedList<int,string> (by key):");
//         foreach (var kv in sorted) Console.WriteLine($" - {kv.Key}: {kv.Value}");

//         // HashSet<T>
//         HashSet<int> set = new HashSet<int>() { 1, 2, 3, 2 };
//         Console.WriteLine("\nHashSet<int> contents (unique values):");
//         foreach (var v in set) Console.WriteLine($" - {v}");

//         Console.WriteLine("\nNotes: Generic collections provide compile-time type safety and better performance than non-generic collections. Prefer these in most scenarios.");
//     }
// }
