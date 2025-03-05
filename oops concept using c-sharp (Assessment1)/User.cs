using System;

namespace ConsoleApp3
{
    class User
    {
        public string Username { get; set; }
        public string Role { get; set; }

        public User(string username, string role)
        {
            Username = username;
            Role = role;
        }

        public virtual void AccessControl()
        {
            Console.WriteLine("Access control is not defined.");
        }
    }

    class Admin : User
    {
        public Admin(string username) : base(username, "Admin") { }

        public override void AccessControl()
        {
            Console.WriteLine($"🔹 Welcome, {Username} (Admin)");
            Console.WriteLine("✅ Full access granted: Manage users, view reports, update settings.");
        }
    }

    class Customer : User
    {
        public Customer(string username) : base(username, "Customer") { }

        public override void AccessControl()
        {
            Console.WriteLine($"🔹 Welcome, {Username} (Customer)");
            Console.WriteLine("⚠ Limited access: View products, make purchases.");
        }
    }
}

