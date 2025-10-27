class Program 
{
    static void Main(string[] args)
    {

        // List = data structure that represents a list of objects that can be accessed by index.
        //        Similar to array, but can dynamically increase/decrease in size 
        //        using System.Collections.Generic;

        List<Int32> food = new List<Int32>();

        // food.Add("pizza");
        // food.Add("hamburger");
        // food.Add("hotdog");
        // food.Add("fries");

        food.Add(1);
        food.Add(2);
        food.Add(3);
        food.Add(4);

        //Console.WriteLine(food[0]);
        //Console.WriteLine(food[1]);
        //Console.WriteLine(food[2]);
        //Console.WriteLine(food[3]);

        //food.Remove("fries");
        //food.Insert(0, "sushi");
        //Console.WriteLine(food.Count);
        //Console.WriteLine(food.IndexOf("pizza"));
        //Console.WriteLine(food.LastIndexOf("fries"));
        //Console.WriteLine(food.Contains("pizza"));
        //food.Sort();
        //food.Reverse();
        //food.Clear();
        //String[] foodArray = food.ToArray();

        foreach (Int32 item in food)
        {
            Console.WriteLine(item);
        }
        Console.ReadKey();
    }
}