using System;

namespace Project
{

    abstract class Vehicle
    {
        public abstract void StartEngine();

        public void StopEngine()
        {
            Console.WriteLine("Engine stopped.");
        }
    }

    class Car : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Car engine started with key ignition.");
        }
    }

    class Bike : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Bike engine started with self-start button.");
        }
    }

    class Abstraction
    {
        public static void Run(string[] args)
        {
            Vehicle myCar = new Car();
            myCar.StartEngine();
            myCar.StopEngine();

            Vehicle myBike = new Bike();
            myBike.StartEngine();
            myBike.StopEngine();
        }
    }
}