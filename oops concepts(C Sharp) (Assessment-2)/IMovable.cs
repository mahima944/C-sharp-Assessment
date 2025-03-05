using System;
namespace ConsoleApp4

{
    interface IMovable
    {
        void Move();
    }
    class Machine
    {
        public string Name { get; set; }

        public void Start()
        {
            Console.WriteLine($"{Name} is starting...");
        }
    } 
    class Robot : Machine, IMovable
    {
        public void Move()
        {
            Console.WriteLine($"{Name} is moving forward...");
        }
    }
}