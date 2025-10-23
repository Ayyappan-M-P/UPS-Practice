using System;
class Swichstatement
{
    public static void Main()
    {
        int number = 3;
        switch (number)
        {
            case 1:
                Console.WriteLine("One");
                break;
            case 2:
                Console.WriteLine("Two");
                break;
            case 3:
                Console.WriteLine("Three");
                break;
            default:
                Console.WriteLine("Other number");
                break;
        }
    }
}