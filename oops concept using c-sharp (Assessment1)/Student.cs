using System;

namespace ConsoleApp3
{
    public class Student
    {
        private string name;
        private int rollNo;

        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    name = value;
                else
                    Console.WriteLine("Invalid Name! Name cannot be empty.");
            }
        }

        public int RollNo
        {
            get { return rollNo; }
            set
            {
                if (value > 0)
                    rollNo = value;
                else
                    Console.WriteLine("Invalid Roll Number! It must be positive.");
            }
        }

        public void DisplayStudentInfo()
        {
            Console.WriteLine($"Student Name: {Name}, Roll Number: {RollNo}");
        }
    }
}
