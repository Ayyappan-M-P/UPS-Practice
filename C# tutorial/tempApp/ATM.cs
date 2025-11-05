using System;

/*
 Simple ATM program

 Requirements satisfied:
 - Accepts customer's name at start and displays it in messages
 - Displays a menu: Deposit, Withdraw, Check Balance, Exit
 - Uses switch-case to handle menu selection
 - Uses a loop to keep showing the menu until Exit is chosen
 - Uses relational operator to ensure enough balance before withdrawal
 - Uses compound assignment operators (+=, -=) to update balance
 
 Usage:
 - Call ATM.Run() from a Main method to run the demo, e.g.:
   static void Main() { ATM.Run(); }
*/

public static class ATM
{
    public static void Run()
    {
    Console.Write("Enter customer name: ");
    string? nameInput = Console.ReadLine();
    string name = string.IsNullOrWhiteSpace(nameInput) ? "Customer" : nameInput.Trim();

        decimal balance = 0m; // starting balance

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine();
            Console.WriteLine($"Welcome, {name}! Choose an option:");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice (1-4): ");

            string? input = Console.ReadLine();
            if (!int.TryParse(input, out int choice))
            {
                Console.WriteLine("Invalid input — please enter a number between 1 and 4.");
                continue;
            }

            switch (choice)
            {
                case 1: // Deposit
                    Console.Write($"{name}, enter amount to deposit: ");
                    string? depStr = Console.ReadLine();
                    if (decimal.TryParse(depStr, out decimal depAmt) && depAmt > 0)
                    {
                        // compound assignment += used to add to balance
                        balance += depAmt;
                        Console.WriteLine($"Deposit successful. New balance for {name}: {balance:C}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid deposit amount. Please enter a positive number.");
                    }
                    break;

                case 2: // Withdraw
                    Console.Write($"{name}, enter amount to withdraw: ");
                    string? wdStr = Console.ReadLine();
                    if (decimal.TryParse(wdStr, out decimal wdAmt) && wdAmt > 0)
                    {
                        // relational operator ensures enough balance
                        if (wdAmt <= balance)
                        {
                            // compound assignment -= used to subtract from balance
                            balance -= wdAmt;
                            Console.WriteLine($"Withdrawal successful. New balance for {name}: {balance:C}");
                        }
                        else
                        {
                            Console.WriteLine($"Insufficient funds. Current balance for {name}: {balance:C}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid withdrawal amount. Please enter a positive number.");
                    }
                    break;

                case 3: // Check Balance
                    Console.WriteLine($"{name}, your current balance is: {balance:C}");
                    break;

                case 4: // Exit
                    Console.WriteLine($"Goodbye, {name}!");
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Please select a valid option (1-4). Try again.");
                    break;
            }
        }
    }
}
