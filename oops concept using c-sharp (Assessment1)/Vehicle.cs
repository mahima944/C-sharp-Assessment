using System;

namespace ConsoleApp3
{
    
    abstract class Vehicle
    {
        public string Model { get; set; }
        public int Speed { get; set; }

        public Vehicle(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }

        
        public abstract void DisplayInfo();
    }

    
    class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public Car(string model, int speed, int numberOfDoors) : base(model, speed)
        {
            NumberOfDoors = numberOfDoors;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"\n🚗 Car Model: {Model}\nSpeed: {Speed} km/h\nDoors: {NumberOfDoors}");
        }
    }

   
    class Bike : Vehicle
    {
        public bool HasGear { get; set; }

        public Bike(string model, int speed, bool hasGear) : base(model, speed)
        {
            HasGear = hasGear;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"\n🏍️ Bike Model: {Model}\nSpeed: {Speed} km/h\nHas Gear: {(HasGear ? "Yes" : "No")}");
        }
    }
}
