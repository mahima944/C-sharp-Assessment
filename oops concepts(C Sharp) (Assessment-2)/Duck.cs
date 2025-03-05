using System;

namespace ConsoleApp4

{
    interface IFlyable
    {
        void Fly();
    }

    
    interface ISwimmable
    {
        void Swim();
    }

   
    class Duck : IFlyable, ISwimmable
    {
        public void Fly()
        {
            Console.WriteLine("The duck is flying high in the sky.");
        }

        public void Swim()
        {
            Console.WriteLine("The duck is swimming gracefully in the pond.");
        }
    }
}