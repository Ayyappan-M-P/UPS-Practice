// class Program
// {
//     static void Main(string[] args)
//     {
//             //getters & setters = add security to fields by encapsulation
//             //                    They're accessors found within properties

//             // properties = combine aspects of both fields and methods (share name with a field)
//             // get accessor = used to return the property value
//             // set accessor = used to assign a new value
//             // value keyword = defines the value being assigned by the set (parameter)
            
//         Car car = new Car(400);

//         car.Speed = 1000000000;

//         Console.WriteLine(car.Speed);

//         Console.ReadKey();
//     }   
// }
// class Car
// {
//     private int speed;
//     //public string Speed{ get; set; } // auto-implemented property

//     public Car(int speed)
//     {
//         Speed = speed;
//     }

//     public int Speed
//     {
//         get { return speed; }
//         set                   
//         {
//             if (value > 500)
//             {
//                 speed = 500;
//             }
//             else
//             {
//                 speed = value;
//             }
//         }
//     }

// }


// using System;

// class BankAccount
// {
//     private double balance; // hidden data (encapsulated)

//     // Method to deposit money
//     public void Deposit(double amount)
//     {
//         if (amount > 0)
//             balance += amount;
//     }

//     // Method to withdraw money
//     public void Withdraw(double amount)
//     {
//         if (amount <= balance)
//             balance -= amount;
//         else
//             Console.WriteLine("Insufficient balance!");
//     }

//     // Method to get balance (controlled access)
//     public double GetBalance()
//     {
//         return balance;
//     }
// }

// class encapsulated
// {
//     static void Main()
//     {
//         BankAccount acc = new BankAccount();
//         acc.Deposit(5000);
//         acc.Withdraw(1000);
//         Console.WriteLine("Balance: " + acc.GetBalance());
//     }
// }
