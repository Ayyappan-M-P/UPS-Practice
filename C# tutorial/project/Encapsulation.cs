using System;

namespace Project
{
    class BankAccount
    {
        private double balance;

        public BankAccount(double amt)
        {
            balance = amt;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited: ${amount}. New balance: ${balance}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrew: ${amount}. New balance: ${balance}");
            }
            else if (amount > balance)
            {
                Console.WriteLine("Insufficient funds.");
            }
            else
            {
                Console.WriteLine("Withdrawal amount must be positive.");
            }
        }

        public double GetBalance()
        {
            return balance;
        }
    }

    class Encapsulation
    {
        public static void Run(string[] args)
        {
            Console.Write("Enter initial balance: ");
            double amt = double.Parse(Console.ReadLine());

            BankAccount account = new BankAccount(amt);

            Console.WriteLine("Welcome to the Bank!");
            Console.WriteLine($"Initial balance: ${account.GetBalance()}");

            bool continueOperations = true;

            while (continueOperations)
            {
                Console.WriteLine("\nChoose an operation:");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice (1-4): ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter deposit amount: ");
                        double depositAmount = Convert.ToDouble(Console.ReadLine());
                        account.Deposit(depositAmount);
                        break;
                    case 2:
                        Console.Write("Enter withdrawal amount: ");
                        double withdrawAmount = Convert.ToDouble(Console.ReadLine());
                        account.Withdraw(withdrawAmount);
                        break;
                    case 3:
                        Console.WriteLine($"Current balance: ${account.GetBalance()}");
                        break;
                    case 4:
                        continueOperations = false;
                        Console.WriteLine("Thank you for using our bank services!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}