using System;

namespace ConsoleApp3
{
    
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

    
        public virtual void GetDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }


    class Students : Person
    {
        public int RollNo { get; set; }

        public override void GetDetails()
        {
            Console.WriteLine($"Student Name: {Name}, Age: {Age}, Roll No: {RollNo}");
        }
    }

    
    class Teacher : Person
    {
        public string Subject { get; set; }

        public override void GetDetails()
        {
            Console.WriteLine($"Teacher Name: {Name}, Age: {Age}, Subject: {Subject}");
        }
    }
}
