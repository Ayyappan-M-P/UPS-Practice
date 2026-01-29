using System;
using System.Collections.Generic;
class Ienumerable
{
    public static void Main(String[] args)
    {
        IEnumerable<string> arr = new List<string> { "apple", "banana", "mango" };
        foreach (var n in arr)
        {
            Console.WriteLine(n);
        }   
    }
}