using System;

namespace ConsoleApp3
{
    public class Manager
    {
        public string Name { get; set; }

        public Manager(string name)
        {
            Name = name;
        }
    }

    public class Department
    {
        public string DeptName { get; set; }
        public Manager DeptManager { get; set; }  

        public Department(string deptName, Manager manager)
        {
            DeptName = deptName;
            DeptManager = manager;
        }

        
        public Department ShallowCopy()
        {
            return (Department)this.MemberwiseClone();
        }

       
        public Department DeepCopy()
        {
            return new Department(DeptName, new Manager(DeptManager.Name));
        }

        public void Display()
        {
            Console.WriteLine($"Department: {DeptName}, Manager: {DeptManager.Name}");
        }
    }
}
