
using ConsoleApp4;
using System;

namespace ConsoleApp4

{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\nSelect a program to run:");
                Console.WriteLine("1.Implemetation of basic inheritance ");
                Console.WriteLine("2.Method Overriding and base class ");
                Console.WriteLine("3.Constructor Chaining in Inheritance");
                Console.WriteLine("4.Abstract Class and Polymorphism");
                Console.WriteLine("5.Interface vs Inheritance in C#");
                Console.WriteLine("6.Sealed Class and Methods");
                Console.WriteLine("7.Multiple Inheritance using Interface");
                Console.WriteLine("8.UpCating and DoemCasting");
                Console.WriteLine("9.Real-World Scenario: E-Commerce System");
                Console.WriteLine("10. Prevent Inheritance Using Sealed Class");

                string choice = Console.ReadLine();


                switch (choice)
                {
                    case "1":
                        RunVehicle();
                        break;

                    case "2":
                        RunMethodOverridingExample();
                        break;
                    case "3":
                        RunEmployeeProgram();
                        break;
                    case "4":
                        RunAnimalProgram();
                        break;
                    case "5":
                        RunRobotProgram();
                        break;
                    case "6":
                        RunSavingsAccountProgram();
                        break;
                    case "7":
                        RunDuckProgram();
                        break;
                    case"8":
                        RunUpcastingDowncasting();
                        break;
                    case "9":
                        RunECommerceSystem();
                        break;
                    case "10":
                        RunSecuritySystem();
                        break;




                    default:
                        Console.WriteLine("Invalid choice! Try again.");
                        break;
                }
            }
        }
        public static void RunVehicle()
        {
            Console.WriteLine(" Basic Inheritance");
            Console.Write("Enter Car Brand: ");
            string carBrand = Console.ReadLine();
            Console.Write("Enter Car Speed: ");
            int carSpeed = int.Parse(Console.ReadLine());
            Console.Write("Enter Number of Doors: ");
            int numDoors = int.Parse(Console.ReadLine());

            Car car = new Car { Brand = carBrand, Speed = carSpeed, NumberOfDoors = numDoors };
            Console.WriteLine("\nCar Details:");
            car.DisplayCarInfo();

            Console.Write("\nEnter Bike Brand: ");
            string bikeBrand = Console.ReadLine();
            Console.Write("Enter Bike Speed: ");
            int bikeSpeed = int.Parse(Console.ReadLine());
            Console.Write("Does the Bike have gears? (yes/no): ");
            bool hasGear = Console.ReadLine().Trim().ToLower() == "yes";

            Bike bike = new Bike { Brand = bikeBrand, Speed = bikeSpeed, HasGear = hasGear };
            Console.WriteLine("\nBike Details:");
            bike.DisplayBikeInfo();

            Console.WriteLine();
        }
        static void RunMethodOverridingExample()
        {
            Console.WriteLine("---- Question 2: Method Overriding ----");

            Console.Write("Enter Sedan Brand: ");
            string sedanBrand = Console.ReadLine();
            Console.Write("Enter Sedan Speed: ");
            int sedanSpeed = int.Parse(Console.ReadLine());
            Console.Write("Enter Number of Doors: ");
            int numDoors = int.Parse(Console.ReadLine());

            Sedan sedan = new Sedan { Brand = sedanBrand, Speed = sedanSpeed, NumberOfDoors = numDoors };
            Console.WriteLine("\nSedan Details:");
            sedan.ShowDetails();

            Console.Write("\nEnter Motorcycle Brand: ");
            string motorcycleBrand = Console.ReadLine();
            Console.Write("Enter Motorcycle Speed: ");
            int motorcycleSpeed = int.Parse(Console.ReadLine());
            Console.Write("Does the Motorcycle have gears? (yes/no): ");
            bool hasGear = Console.ReadLine().Trim().ToLower() == "yes";

            Motorcycle motorcycle = new Motorcycle { Brand = motorcycleBrand, Speed = motorcycleSpeed, HasGear = hasGear };
            Console.WriteLine("\nMotorcycle Details:");
            motorcycle.ShowDetails();
        }

        static void RunEmployeeProgram()
        {
            Console.WriteLine("---- Question 3: Constructor Chaining ----");

            Console.Write("Enter Employee Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Salary: ");
            double salary = double.Parse(Console.ReadLine());
            Console.Write("Enter Bonus for Manager: ");
            double bonus = double.Parse(Console.ReadLine());

            Manager manager = new Manager(name, salary, bonus);

            Console.WriteLine("\nManager Details:");
            manager.DisplayInfo();
        }
        static void RunAnimalProgram()
        {
            Console.WriteLine("---- Question 4: Abstract Class & Polymorphism ----");


            Console.Write("Enter Dog's Name: ");
            string dogName = Console.ReadLine();
            Dog dog = new Dog { Name = dogName };


            Console.Write("Enter Cat's Name: ");
            string catName = Console.ReadLine();
            Cat cat = new Cat { Name = catName };


            Console.WriteLine("\nAnimal Sounds:");
            dog.MakeSound();
            cat.MakeSound();
        }
        static void RunRobotProgram()
        {
            Console.WriteLine("---- Question 5: Interface vs Inheritance ----");


            Console.Write("Enter Robot Name: ");
            string robotName = Console.ReadLine();


            Robot robot = new Robot { Name = robotName };


            robot.Start();
            robot.Move();
        }
        static void RunSavingsAccountProgram()
        {
            Console.WriteLine("---- Question 6: Sealed Class and Methods ----");
            Console.Write("Enter Account Holder Name: ");
            string holderName = Console.ReadLine();

            Console.Write("Enter Account Balance: ");
            double balance = double.Parse(Console.ReadLine());

            Console.Write("Enter Interest Rate (%): ");
            double interestRate = double.Parse(Console.ReadLine());


            SavingsAccount savings = new SavingsAccount
            {
                AccountHolder = holderName,
                Balance = balance,
                InterestRate = interestRate
            };


            savings.CalculateInterest();
        }
        static void RunDuckProgram()
        {
            Console.WriteLine("---- Question 7: Multiple Inheritance Using Interfaces ----");


            Duck duck = new Duck();


            duck.Fly();
            duck.Swim();
        }
        static void RunUpcastingDowncasting()
        {
            Console.WriteLine("---- Question 8: Upcasting and Downcasting ----");
            Student student = new Student { Name = "Alice", StudentID = 101 };
            Person person = student;
            Console.WriteLine("\nAfter Upcasting to Person:");
            person.ShowInfo(); 
            if (person is Student downcastedStudent)
            {
                Console.WriteLine("\nAfter Downcasting back to Student:");
                downcastedStudent.ShowInfo();
                downcastedStudent.Study();
            }
            else
            {
                Console.WriteLine("Downcasting failed!");
            }

        }
        static void RunECommerceSystem()
        {
            Console.WriteLine("---- Question 9: E-Commerce System ----");

            
            Console.Write("\nEnter Electronic Product Name: ");
            string elecName = Console.ReadLine();
            Console.Write("Enter Electronic Product Price: ");
            double elecPrice = double.Parse(Console.ReadLine());

            Console.Write("\nEnter Clothing Product Name: ");
            string clothName = Console.ReadLine();
            Console.Write("Enter Clothing Product Price: ");
            double clothPrice = double.Parse(Console.ReadLine());

   
            ElectronicProduct laptop = new ElectronicProduct(elecName, elecPrice);
            ClothingProduct tshirt = new ClothingProduct(clothName, clothPrice);

          
            Console.WriteLine("\nProduct Details:");
            laptop.DisplayInfo();
            tshirt.DisplayInfo();
        }

        static void RunSecuritySystem()
        {
            SecuritySystem system = new SecuritySystem();
            system.AuthenticateUser();
        }
    }
}

    



           
    
