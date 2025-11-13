// public delegate void MaintenanceAlertHandler(string message);

// public abstract class Vehicle
// {
//     public string Name { get; set; }
//     public double FuelLevel { get; set; } 

//     public MaintenanceAlertHandler Alert;

//     public Vehicle(string name, double fuelLevel)
//     {
//         Name = name;
//         FuelLevel = fuelLevel;
//     }

//     public abstract void CheckFuel();
// }

// public class Car : Vehicle
// {
//     public Car(string name, double fuelLevel) : base(name, fuelLevel) { }

//     public override void CheckFuel()
//     {
//         if (FuelLevel <= 15)
//         {
//             Console.WriteLine($"Car {Name} has low fuel! ({FuelLevel}% remaining)");
//         }
//         else
//         {
//             Console.WriteLine($"Car {Name} has sufficient fuel ({FuelLevel}%).");
//         }
//     }
// }

// public class Truck : Vehicle
// {
//     public Truck(string name, double fuelLevel) : base(name, fuelLevel) { }

//     public override void CheckFuel()
//     {
//         if (FuelLevel <= 20)
//         {
//             Console.WriteLine($"Truck {Name} fuel is running low! ({FuelLevel}% remaining)");
//         }
//         else
//         {
//             Console.WriteLine($"Truck {Name} has enough fuel ({FuelLevel}%).");
//         }
//     }
// }

// public class Bike : Vehicle
// {
//     public Bike(string name, double fuelLevel) : base(name, fuelLevel) { }

//     public override void CheckFuel()
//     {
//         if (FuelLevel <= 10)
//         {
//             Console.WriteLine($"Bike {Name} needs refueling soon! ({FuelLevel}% remaining)");
//         }
//         else
//         {
//             Console.WriteLine($"Bike {Name} fuel level is okay ({FuelLevel}%).");
//         }
//     }
// }

// class Program1
// {
//     static void Main()
//     {
//         Car car = new Car("BMW", 12);
//         Truck truck = new Truck("TATA", 35);
//         Bike bike = new Bike("MT15", 8);

//         car.Alert = DisplayAlert;
//         truck.Alert = DisplayAlert;
//         bike.Alert = DisplayAlert;

//         car.CheckFuel();
//         truck.CheckFuel();
//         bike.CheckFuel();
//     }

//     static void DisplayAlert(string message)
//     {
        
//         Console.WriteLine("\nALERT: " + message);
        
//     }
// }
