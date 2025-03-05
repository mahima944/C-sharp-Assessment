using System;

namespace ConsoleApp4

{
    class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        
        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Employee Name: {Name}");
            Console.WriteLine($"Salary: {Salary:C}");
        }
    }

    class Manager : Employee
    {
        public double Bonus { get; set; }

        
        public Manager(string name, double salary, double bonus) : base(name, salary)
        {
            Bonus = bonus;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Bonus: {Bonus:C}");
        }
    }
}
