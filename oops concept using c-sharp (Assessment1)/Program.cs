using System;
using ConsoleApp3;  
using LoggerSystem;
namespace ConsoleApp3
{
    class Program
{
    static void Main()
    {
       
            while (true)
            {
                Console.WriteLine("\nSelect a program to run:");
                Console.WriteLine("1. Bank Account (Encapsulation)");
                Console.WriteLine("2. Student Data (Properties & Data Hiding)");
                Console.WriteLine("3. Library System (Constructor Overloading)");
                Console.WriteLine("4. Shape System (Abstraction with Abstract Classes)");

                Console.WriteLine("5. Vehicle System (Abstraction)");
                Console.WriteLine("6. Person Details (Inheritance & Polymorphism)");
                Console.WriteLine("7. Calculator (Method Overloading)");
                Console.WriteLine("8. Playable (Interface Implementation)");
                Console.WriteLine("9. Report System (Multiple Interface Inheritance)");
                Console.WriteLine("10. Role-Based Access System (Polymorphism)");
                Console.WriteLine("11. Complex Number Addition (Operator Overloading)");
                Console.WriteLine("12. Shallow vs. Deep Copy (Cloning)");
                Console.WriteLine("13. Banking System (Static Members)");
                Console.WriteLine("14. Security System (Sealed Class)");
                Console.WriteLine("15. Button Click Event (Delegates)");
                Console.WriteLine("16. Vehicle Factory (Factory Pattern)");
                Console.WriteLine("17. Logger System ");
                Console.WriteLine("18. Configuration Management(singleton pattern) ");
                Console.WriteLine("19.Pattern for notifications  ");
                Console.WriteLine("20. Pattern for Discount Calculation ");
                Console.WriteLine("21. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        RunBankAccountProgram();
                        break;
                    case "2":
                        RunStudentProgram();
                        break;
                    case "3":
                        RunLibrarySystem();
                        break;
                    case "4":
                        RunShapeProgram();
                        break;

                    case "5":
                        RunVehicleProgram();
                        break;
                    case "6":
                        RunPersonProgram();
                        break;
                    case "7":
                        RunCalculatorProgram();
                        break;
                    case "8":
                        RunPlayableProgram();
                        break;
                    case "9":
                        RunReportSystem();
                        break;
                    case "10":
                        RunAccessControlSystem();
                        break;
                    case "11":
                        RunComplexNumberProgram();
                        break;
                    case "12":
                        RunDepartmentCloning();
                        break;
                    case "13":
                        RunBankingSystem();
                        break;
                    case "14":
                        RunSecuritySystem();
                        break;
                    case "15":
                        RunButtonEvent();
                        break;

                    case "16":
                        RuvehicleFactory();
                        break;


                    case "17":
                        RunloggerApp();
                        break;
                    case "18":
                        RunSingletonPattern();
                        break;

                    case "19":
                        RunNotificationObserver();
                        break;

                    case "20":
                        RunDiscountCalculation();
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Try again.");
                        break;
                }
            }
        }

        
        static void RunBankAccountProgram()
        {
            Console.Write("Enter initial balance: ");
            decimal initialBalance;

            while (!decimal.TryParse(Console.ReadLine(), out initialBalance) || initialBalance < 0)
            {
                Console.WriteLine("Invalid input! Please enter a valid non-negative balance: ");
            }

            BankAccount myAccount = new BankAccount(initialBalance);

            while (true)
            {
                Console.WriteLine("\nChoose an action: ");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Back to Main Menu");

                Console.Write("Enter your choice: ");
                string action = Console.ReadLine();

                if (action == "1")
                {
                    Console.Write("Enter deposit amount: ");
                    decimal depositAmount;
                    while (!decimal.TryParse(Console.ReadLine(), out depositAmount) || depositAmount <= 0)
                    {
                        Console.WriteLine("Invalid input! Please enter a valid deposit amount.");
                    }
                    myAccount.Deposit(depositAmount);
                }
                else if (action == "2")
                {
                    Console.Write("Enter withdrawal amount: ");
                    decimal withdrawAmount;
                    while (!decimal.TryParse(Console.ReadLine(), out withdrawAmount) || withdrawAmount <= 0)
                    {
                        Console.WriteLine("Invalid input! Please enter a valid withdrawal amount.");
                    }
                    myAccount.Withdraw(withdrawAmount);
                }
                else if (action == "3")
                {
                    Console.WriteLine($"Current Balance: {myAccount.GetBalance()}");
                }
                else if (action == "4")
                {
                    Console.WriteLine("Returning to Main Menu...");
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid choice! Please select a valid option.");
                }
            }
        }

        
        static void RunStudentProgram()
        {
            Student student = new Student();

            Console.Write("Enter Student Name: ");
            string inputName = Console.ReadLine();
            student.Name = inputName;

            Console.Write("Enter Roll Number: ");
            int inputRollNo;

            while (!int.TryParse(Console.ReadLine(), out inputRollNo) || inputRollNo <= 0)
            {
                Console.WriteLine("Invalid Roll Number! It must be a positive integer. Try again:");
            }

            student.RollNo = inputRollNo;

            Console.WriteLine("\nStudent Details:");
            student.DisplayStudentInfo();
        }

        
        static void RunLibrarySystem()
        {
            Console.WriteLine("\nChoose how to create a book:");
            Console.WriteLine("1. Default Book");
            Console.WriteLine("2. Book with Title and Author");
            Console.WriteLine("3. Book with Title, Author, and ISBN");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();
            Book book;

            switch (choice)
            {
                case "1":
                    book = new Book();
                    break;
                case "2":
                    Console.Write("Enter Title: ");
                    string title1 = Console.ReadLine();
                    Console.Write("Enter Author: ");
                    string author1 = Console.ReadLine();
                    book = new Book(title1, author1);
                    break;
                case "3":
                    Console.Write("Enter Title: ");
                    string title2 = Console.ReadLine();
                    Console.Write("Enter Author: ");
                    string author2 = Console.ReadLine();
                    Console.Write("Enter ISBN: ");
                    string isbn = Console.ReadLine();
                    book = new Book(title2, author2, isbn);
                    break;
                default:
                    Console.WriteLine("Invalid choice! Creating default book.");
                    book = new Book();
                    break;
            }

            book.DisplayBookInfo();
        }
        static void RunVehicleProgram()
        {
            Console.WriteLine("\nChoose a vehicle to create:");
            Console.WriteLine("1. Car");
            Console.WriteLine("2. Bike");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();
            Vehicle vehicle;

            switch (choice)
            {
                case "1":
                    Console.Write("Enter Car Model: ");
                    string carModel = Console.ReadLine();

                    Console.Write("Enter Speed (km/h): ");
                    int carSpeed;
                    while (!int.TryParse(Console.ReadLine(), out carSpeed) || carSpeed < 0)
                    {
                        Console.WriteLine("Invalid speed! Enter a valid speed (km/h).");
                    }

                    Console.Write("Enter Number of Doors: ");
                    int doors;
                    while (!int.TryParse(Console.ReadLine(), out doors) || doors <= 0)
                    {
                        Console.WriteLine("Invalid input! Doors must be a positive integer.");
                    }

                    vehicle = new Car(carModel, carSpeed, doors);
                    break;

                case "2":
                    Console.Write("Enter Bike Model: ");
                    string bikeModel = Console.ReadLine();

                    Console.Write("Enter Speed (km/h): ");
                    int bikeSpeed;
                    while (!int.TryParse(Console.ReadLine(), out bikeSpeed) || bikeSpeed < 0)
                    {
                        Console.WriteLine("Invalid speed! Enter a valid speed (km/h).");
                    }

                    Console.Write("Does the bike have gears? (yes/no): ");
                    bool hasGear = Console.ReadLine().Trim().ToLower() == "yes";

                    vehicle = new Bike(bikeModel, bikeSpeed, hasGear);
                    break;

                default:
                    Console.WriteLine("Invalid choice! Creating a default Bike.");
                    vehicle = new Bike("Default Bike", 50, false);
                    break;
            }

            vehicle.DisplayInfo();
        }
        static void RunShapeProgram()
        {
            Console.WriteLine("\nChoose a shape:");
            Console.WriteLine("1. Circle");
            Console.WriteLine("2. Rectangle");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();
            Shape shape;

            if (choice == "1")
            {
                Console.Write("Enter the radius of the circle: ");
                double radius;
                while (!double.TryParse(Console.ReadLine(), out radius) || radius <= 0)
                {
                    Console.WriteLine("Invalid input! Please enter a valid radius.");
                }

                shape = new Circle(radius);
            }
            else if (choice == "2")
            {
                Console.Write("Enter the width of the rectangle: ");
                double width;
                while (!double.TryParse(Console.ReadLine(), out width) || width <= 0)
                {
                    Console.WriteLine("Invalid input! Please enter a valid width.");
                }

                Console.Write("Enter the height of the rectangle: ");
                double height;
                while (!double.TryParse(Console.ReadLine(), out height) || height <= 0)
                {
                    Console.WriteLine("Invalid input! Please enter a valid height.");
                }

                shape = new Rectangle(width, height);
            }
            else
            {
                Console.WriteLine("Invalid choice! Returning to Main Menu...");
                return;
            }

            
            Console.WriteLine($"The area of the selected shape is: {shape.CalculateArea():F2}");
        }
        static void RunPersonProgram()
        {
            Console.WriteLine("\nChoose a role:");
            Console.WriteLine("1. Student");
            Console.WriteLine("2. Teacher");
            Console.Write("Enter choice: ");
            string choice = Console.ReadLine();

            Person person; 

            if (choice == "1")
            {
                Students student = new Students();
                Console.Write("Enter Student Name: ");
                student.Name = Console.ReadLine();
                Console.Write("Enter Age: ");
                student.Age = int.Parse(Console.ReadLine());
                Console.Write("Enter Roll Number: ");
                student.RollNo = int.Parse(Console.ReadLine());

                person = student;  
            }
            else if (choice == "2")
            {
                Teacher teacher = new Teacher();
                Console.Write("Enter Teacher Name: ");
                teacher.Name = Console.ReadLine();
                Console.Write("Enter Age: ");
                teacher.Age = int.Parse(Console.ReadLine());
                Console.Write("Enter Subject: ");
                teacher.Subject = Console.ReadLine();

                person = teacher;  
            }
            else
            {
                Console.WriteLine("Invalid choice!");
                return;
            }

            Console.WriteLine("\nDetails:");
            person.GetDetails();  
        }
        static void RunCalculatorProgram()
        {
            Calculator calc = new Calculator();

            Console.WriteLine("\nSelect addition type:");
            Console.WriteLine("1. Add two integers");
            Console.WriteLine("2. Add three integers");
            Console.WriteLine("3. Add two double values");
            Console.Write("Enter choice: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter first integer: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Enter second integer: ");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine($"Result: {calc.Add(num1, num2)}");
            }
            else if (choice == "2")
            {
                Console.Write("Enter first integer: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Enter second integer: ");
                int num2 = int.Parse(Console.ReadLine());
                Console.Write("Enter third integer: ");
                int num3 = int.Parse(Console.ReadLine());
                Console.WriteLine($"Result: {calc.Add(num1, num2, num3)}");
            }
            else if (choice == "3")
            {
                Console.Write("Enter first double: ");
                double num1 = double.Parse(Console.ReadLine());
                Console.Write("Enter second double: ");
                double num2 = double.Parse(Console.ReadLine());
                Console.WriteLine($"Result: {calc.Add(num1, num2)}");
            }
            else
            {
                Console.WriteLine("Invalid choice!");
            }
        }
        static void RunPlayableProgram()
        {
            Console.WriteLine("\nChoose player type:");
            Console.WriteLine("1. Music Player");
            Console.WriteLine("2. Video Player");
            Console.Write("Enter choice: ");

            string choice = Console.ReadLine();
            IPlayable player;  

            if (choice == "1")
            {
                player = new MusicPlayer();
            }
            else if (choice == "2")
            {
                player = new VideoPlayer();
            }
            else
            {
                Console.WriteLine("Invalid choice!");
                return;
            }

            player.Play();  
        }

        static void RunReportSystem()
        {
            Console.Write("\nEnter Report Title: ");
            string title = Console.ReadLine();

            Console.Write("Enter Report Content: ");
            string content = Console.ReadLine();

            Report report = new Report(title, content);

            Console.WriteLine("\n📄 Printing Report:");
            report.PrintDetails();

            Console.WriteLine("\n💾 Saving Report:");
            report.SaveToFile();
        }
        static void RunAccessControlSystem()
        {
            Console.Write("\nEnter your username: ");
            string username = Console.ReadLine();

            Console.Write("Enter your role (Admin/Customer): ");
            string role = Console.ReadLine().Trim().ToLower();

            User user;

            if (role == "admin")
            {
                user = new Admin(username);
            }
            else if (role == "customer")
            {
                user = new Customer(username);
            }
            else
            {
                Console.WriteLine("❌ Invalid role! Defaulting to Customer.");
                user = new Customer(username);
            }

            user.AccessControl();  
        }
        static void RunComplexNumberProgram()
        {
            Console.WriteLine("\n📌 Complex Number Addition using Operator Overloading");

            Console.Write("Enter real part of first complex number: ");
            double real1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter imaginary part of first complex number: ");
            double imaginary1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter real part of second complex number: ");
            double real2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter imaginary part of second complex number: ");
            double imaginary2 = Convert.ToDouble(Console.ReadLine());

            ComplexNumber c1 = new ComplexNumber(real1, imaginary1);
            ComplexNumber c2 = new ComplexNumber(real2, imaginary2);

            ComplexNumber result = c1 + c2;

            Console.WriteLine($"\n✅ Result: {c1} + {c2} = {result}");
        }
        static void RunDepartmentCloning()
        {
            Console.WriteLine("\n📌 Shallow Copy vs. Deep Copy in Department Class");

            
            Manager mgr1 = new Manager("Alice");
            Department dept1 = new Department("IT", mgr1);

            
            Department shallowCopy = dept1.ShallowCopy();

            
            Department deepCopy = dept1.DeepCopy();

            Console.WriteLine("\n✅ Before Modification:");
            Console.WriteLine("Original:");
            dept1.Display();
            Console.WriteLine("Shallow Copy:");
            shallowCopy.Display();
            Console.WriteLine("Deep Copy:");
            deepCopy.Display();

            
            dept1.DeptManager.Name = "Bob";

            Console.WriteLine("\n🔄 After Modifying Original Manager's Name:");
            Console.WriteLine("Original:");
            dept1.Display();
            Console.WriteLine("Shallow Copy (Affected ❌):");
            shallowCopy.Display();
            Console.WriteLine("Deep Copy (Unaffected ✅):");
            deepCopy.Display();
        }
        static void RunBankingSystem()
        {
            Console.WriteLine("\n📌 Static Members in Banking System");

            
            Bank acc1 = new Bank("Alice", 5000);
            Bank acc2 = new Bank("Bob", 10000);

            Console.WriteLine("\n✅ Initial Interest Rate:");
            acc1.Display();
            acc2.Display();

            
            Bank.SetInterestRate(5.0);

            Console.WriteLine("\n🔄 After Changing Interest Rate:");
            acc1.Display();
            acc2.Display();
        }
        static void RunSecuritySystem()
        {
            Console.WriteLine("\n📌 Sealed Class in Security System");

            SecuritySystem security = new SecuritySystem("SS1001", "Admin");
            security.Authenticate();
        }
        static void RunButtonEvent()
        {
            Console.WriteLine("\n📌 Delegates & Event Handling - Button Click Example");

            
            Button button = new Button("Submit");

            
            button.OnClick += ButtonClickedHandler;

           
            button.Click();
        }
        static void ButtonClickedHandler()
        {
            Console.WriteLine("✅ Button click event triggered! Performing an action...");
        }
        
        static void RunloggerApp()
        {
            
            ILogger fileLogger = new FileLogger();

           
            ILogger timestampLogger = new TimestampLogger(fileLogger);

           
            ILogger errorLogger = new ErrorCategoryLogger(timestampLogger, "ERROR");

            
            errorLogger.Log("This is a test log message.");
        }
        static void RunSingletonPattern()
        {
            ConfigurationManager config = ConfigurationManager.Instance;

            config.SetConfig("AppName", "SingletonApp");
            config.SetConfig("Version", "1.0.0");

            Console.WriteLine($"App Name: {config.GetConfig("AppName")}");
            Console.WriteLine($"Version: {config.GetConfig("Version")}");
        }
        static void RunNotificationObserver()
        {
            NotificationService service = new NotificationService();

            INotificationObserver emailNotifier = new EmailNotifier();
            INotificationObserver smsNotifier = new SMSNotifier();

            service.AddObserver(emailNotifier);
            service.AddObserver(smsNotifier);

            Console.WriteLine("Sending first notification...");
            service.NotifyObservers("New message received!");

            service.RemoveObserver(emailNotifier);

            Console.WriteLine("\nSending second notification...");
            service.NotifyObservers("Another message received!");
        }
        static void RunDiscountCalculation()
        {

            ShoppingCart cart = new ShoppingCart();

            Console.WriteLine("Enter total amount: ");
            decimal totalAmount = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Choose discount type: 1 - No Discount, 2 - Percentage, 3 - Fixed Amount");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    cart.SetDiscountStrategy(new NoDiscount());
                    break;
                case 2:
                    Console.WriteLine("Enter percentage discount: ");
                    decimal percentage = Convert.ToDecimal(Console.ReadLine());
                    cart.SetDiscountStrategy(new PercentageDiscount(percentage));
                    break;
                case 3:
                    Console.WriteLine("Enter fixed discount amount: ");
                    decimal fixedAmount = Convert.ToDecimal(Console.ReadLine());
                    cart.SetDiscountStrategy(new FixedAmountDiscount(fixedAmount));
                    break;
                default:
                    Console.WriteLine("Invalid choice, applying No Discount.");
                    cart.SetDiscountStrategy(new NoDiscount());
                    break;
            }

            decimal finalTotal = cart.CalculateTotal(totalAmount);
            Console.WriteLine($"Final Total after Discount: {finalTotal}");


        }

        static void RuvehicleFactory()
        {
            Console.Write("Enter transport type (Sedan/Motorcycle): ");
            string type = Console.ReadLine();

            try
            {
                ITransport transport = TransportFactory.GetTransport(type);
                transport.DisplayInfo();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}

   