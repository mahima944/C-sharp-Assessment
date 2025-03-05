using System;
namespace ConsoleApp4
{
    abstract class Animal
    {
        public string Name { get; set; }
        public abstract void MakeSound();
    }

    
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} (Dog) says: Woof Woof!");
        }
    }

    
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} (Cat) says: Meow Meow!");
        }
    }
}
