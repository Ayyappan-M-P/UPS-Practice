using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Welcome to the Simple ATM");
        Console.Write("Please enter your name: ");
        string customerName = Console.ReadLine();

        decimal balance = 0; 
        int choice = 0;

        do
        {
            Console.WriteLine($"\nHello, {customerName}! Please choose an option:");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice (1-4): ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter amount to deposit: ");
                    decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
                    if (depositAmount > 0)
                    {
                        balance += depositAmount; 
                        Console.WriteLine($"{customerName}, you have successfully deposited {depositAmount}. Current balance: {balance}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount! Please enter a positive number.");
                    }ā
                    break;ā

                case 2:
                    Console.Write("Enter amount to withdraw: ");
                    decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());
                    if (withdrawAmount > 0)
                    {
                        if (withdrawAmount <= balance)
                        {
                            balance -= withdrawAmount; 
                            Console.WriteLine($"{customerName}, you have withdrawn {withdrawAmount}. Remaining balance: {balance}");
                        }
                        else
                        {
                            Console.WriteLine($"{customerName}, insufficient balance! Your current balance is {balance}.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount! Please enter a positive number.");
                    }
                    break;

                case 3:
                    Console.WriteLine($"{customerName}, your current balance is: {balance}");
                    break;

                case 4:
                    Console.WriteLine($"Thank you, {customerName}, for using the Simple ATM. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice! Please select between 1 and 4.");
                    break;
            }

        } while (choice != 4);
    }
}
