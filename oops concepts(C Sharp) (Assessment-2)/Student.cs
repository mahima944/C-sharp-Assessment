using System;

namespace ConsoleApp4
{

    class Person
    {
        public string Name { get; set; }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Person Name: {Name}");
        }
    }

    class Student : Person
    {
        public int StudentID { get; set; }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Student ID: {StudentID}");
        }

        public void Study()
        {
            Console.WriteLine($"{Name} is studying.");
        }
    }
}
