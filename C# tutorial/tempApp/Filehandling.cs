using System.IO;
using System;
public class Filehandling
{
    public static void Main()
    {
        string filePath = "example.txt";
       
        File.WriteAllText(filePath, "Hello this is the first line\n");

        string content = File.ReadAllText(filePath);
        Console.WriteLine("File content:");
        Console.WriteLine(content);

        File.AppendAllText(filePath, "This line was appended.\n");

        content = File.ReadAllText(filePath);
        Console.WriteLine("\nFile content after appending:");
        Console.WriteLine(content);

        // File.Delete(filePath);
        // Console.WriteLine("\nFile deleted successfully.");
    }
}