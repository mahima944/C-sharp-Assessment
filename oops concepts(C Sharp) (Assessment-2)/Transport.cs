using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Transport
    {
        public string Brand { get; set; }
        public int Speed { get; set; }

        public virtual void ShowDetails()
        {
            Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h");
        }
    }

    
    class Sedan : Transport
    {
        public int NumberOfDoors { get; set; }

        public override void ShowDetails()
        {
            base.ShowDetails();  
            Console.WriteLine($"Number of Doors: {NumberOfDoors}");
        }
    }

    
    class Motorcycle : Transport
    {
        public bool HasGear { get; set; }

        public override void ShowDetails()
        {
            base.ShowDetails();  
            Console.WriteLine($"Has Gear: {(HasGear ? "Yes" : "No")}");
        }
    }


    }
