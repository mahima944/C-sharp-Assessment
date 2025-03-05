using System;

namespace ConsoleApp4
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public int Speed { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h");
        }
    }

    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public void DisplayCarInfo()
        {
            DisplayInfo();
            Console.WriteLine($"Number of Doors: {NumberOfDoors}");
        }
    }

    public class Bike : Vehicle
    {
        public bool HasGear { get; set; }

        public void DisplayBikeInfo()
        {
            DisplayInfo();
            Console.WriteLine($"Has Gear: {(HasGear ? "Yes" : "No")}");
        }
    }
}