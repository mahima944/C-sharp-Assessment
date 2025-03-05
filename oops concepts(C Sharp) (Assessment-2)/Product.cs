using System;

namespace ConsoleApp4
{

    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual double GetDiscountedPrice()
        {
            return Price;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Product: {Name}, Price: ${Price:F2}, Discounted Price: ${GetDiscountedPrice():F2}");
        }
    }


    class ElectronicProduct : Product
    {
        public ElectronicProduct(string name, double price) : base(name, price) { }

        public override double GetDiscountedPrice()
        {
            return Price * 0.9;
        }
    }


    class ClothingProduct : Product
    {
        public ClothingProduct(string name, double price) : base(name, price) { }

        public override double GetDiscountedPrice()
        {
            return Price * 0.8;
        }
    }
}